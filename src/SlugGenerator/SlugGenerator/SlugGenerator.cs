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


           string slug = Regex.Replace(Regex.Replace(input.ToLower().Trim().Replace(" ","-").Replace("_","-")
                , @"[^a-z0-9-]", "")
                , @"-+", "-").Trim('-');


            return slug;
            
        }
    }
}
