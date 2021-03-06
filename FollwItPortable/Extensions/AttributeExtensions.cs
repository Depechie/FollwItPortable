﻿using FollwItPortable.Attributes;

namespace FollwItPortable.Extensions
{
    internal static class AttributeExtensions
    {
        internal static string GetDescription(this object en)
        {
            var type = en.GetType();
            var memInfo = type.GetMember(en.ToString());

            if (memInfo.Length <= 0) return en.ToString();

            var attrs = memInfo[0].GetCustomAttributes(typeof(Description), false);
            if (attrs != null && attrs.Length > 0)
            {
                return ((Description)attrs[0]).Text;
            }

            return en.ToString();
        }
    }
}