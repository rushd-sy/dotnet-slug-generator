using System;

namespace SlugGenerator
{
    public static class SlugGenerator
    {
        public static string GenerateSlug(string input)
        {
            string slug = string.Empty;
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]))
                    {
                        slug += char.ToLower(input[i]);
                    }
                    else if((i==0 || i==input.Length-1)&&!char.IsLetter(input[i]))
                    {
                        continue;

                    }
                    else if (!char.IsLetter(input[i]) && !char.IsLetter(input[i - 1]))
                    {
                        continue;
                    }
                    else
                    {
                        slug += '-';
                    }
                }

            }
            catch(Exception ex)
            {
                throw ex;

            }
            return slug;
            
        }
    }
}
