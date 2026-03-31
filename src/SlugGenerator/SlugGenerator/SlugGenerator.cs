using System;
using System.Text.RegularExpressions;

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
            string slug = input.ToLower().Trim();

            slug = slug.Replace(" ", "-").Replace("_", "-");

            slug = Regex.Replace(slug, @"[^a-z0-9\-]", "");

            slug = Regex.Replace(slug, @"-+", "-");

            slug = slug.Trim('-');

            return slug;
            
        }
    }
}
