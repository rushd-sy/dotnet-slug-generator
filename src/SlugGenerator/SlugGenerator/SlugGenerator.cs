using System.Text.RegularExpressions;

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
            string slug= new string(input.ToLower().Trim().Select(c=> (char.IsWhiteSpace(c) || c=='_') ? slugBy : c)
                .Where(c=> (char.IsLetterOrDigit(c) || c==slugBy)).ToArray());

            return slug;
            
        }
    }
}
