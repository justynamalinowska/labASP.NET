using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

namespace Laboratorium3_Product.Models
{
    static public class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var displayAttribute = enumValue.GetType()
                                           .GetMember(enumValue.ToString())
                                           .FirstOrDefault()
                                           ?.GetCustomAttribute<DisplayAttribute>();

            return displayAttribute?.GetName() ?? string.Empty;
        }
    }
}
