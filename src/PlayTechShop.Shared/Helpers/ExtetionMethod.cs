using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTechShop.Shared.Helpers;
public static class ExtetionMethod
{
    public static string RemoveScore(this string text)
    {
        return !string.IsNullOrEmpty(text) ? text.Replace(".", "").Replace("-", "").Replace("/", "").Replace("(", "").Replace(")", "").Replace(" ", "") : text;
    }
    public static string RemoveSpace(this string text)
    {
        return !string.IsNullOrEmpty(text) ? text.ToLower().Trim().TrimStart().TrimEnd() : text;
    }
}
