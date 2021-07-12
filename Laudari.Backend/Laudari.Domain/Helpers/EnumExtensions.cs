using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Laudari.Domain.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            try { 
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
