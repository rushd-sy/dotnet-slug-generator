using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace SlugGenerator
{
    public static class SlugGenerator
    {
        public static string GenerateSlug(this string input,char slugBy)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            string slug = input;

            slug = Regex.Replace(Regex.Replace(input.ToLower().Trim().Replace(" ",slugBy.ToString()).Replace("_",slugBy.ToString())
                , @"[^a-z0-9" + Regex.Escape(slugBy.ToString()) + "]", "")
                , $@"{Regex.Escape(slugBy.ToString())}+", $"{slugBy}").Trim(slugBy);


            return slug;
            
        }
    }
}
