using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace SlugGenerator
{
    public static class SlugGenerator
    {
        public static string GenerateSlug(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            string slug = input;

            slug = Regex.Replace(Regex.Replace(input.ToLower().Trim().Replace(" ","_").Replace("-","_")
                , @"[^a-z0-9_]", "")
                , @"_+", "_").Trim('_');


            return slug;
            
        }
    }
}
