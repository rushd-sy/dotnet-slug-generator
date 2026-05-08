using System.Security.Cryptography.X509Certificates;
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
            string uniqueHash=Guid.NewGuid().ToString("N").Substring(0,8);

            return $"{slug}{slugBy}{uniqueHash}";
            
        }
    }
}
