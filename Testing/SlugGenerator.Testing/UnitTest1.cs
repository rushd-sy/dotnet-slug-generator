using Xunit;
using SlugGenerator
;

public class SlugGeneratorTests
{
    [Theory]
    [InlineData("Hello World", "hello-world")]
    [InlineData("This is a Test!", "this-is-a-test")]
    [InlineData("C# Programming", "c-programming")]
    [InlineData("   Leading and Trailing Spaces   ", "leading-and-trailing-spaces")]
    [InlineData("Multiple---Dashes", "multiple-dashes")]
    [InlineData("Special Characters!@#$%^&*()", "special-characters")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("شقة للبيع","شقة-للبيع")]
    public void GenerateSlug_ShouldReturnExpectedSlug(string input, string expected)
    {
        
        // Act
        string result = input.GenerateUnique('-');
        // Assert
        Assert.Equal(expected, result);
    }
}