using Xunit;
using SlugGenerator;

public class SlugGeneratorTests
{
    [Theory]
    [InlineData("Hello World", "hello_world")]
    [InlineData("This is a Test!", "this_is_a_test")]
    [InlineData("C# Programming", "c_programming")]
    [InlineData("   Leading and Trailing Spaces   ", "leading_and_trailing_spaces")]
    [InlineData("Multiple---Dashes", "multiple_dashes")]
    [InlineData("Special Characters!@#$%^&*()", "special_characters")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("شقة للبيع","شقة_للبيع")]
    public void GenerateSlug_ShouldReturnExpectedSlug(string input, string expected)
    {
        
        // Act
        string result = SlugGenerator.SlugGenerator.GenerateSlug(input);
        // Assert
        Assert.Equal(expected, result);
    }
}