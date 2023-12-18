using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        string input = string.Empty;

        string result = CamelCaseConverter.ConvertToCamelCase(input);

        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        string input = "ConvertMe";
        string expected = "convertme";

        string result = CamelCaseConverter.ConvertToCamelCase((string)input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        string input = "what is going on";
        string expected = "whatIsGoingOn";

        string result = CamelCaseConverter.ConvertToCamelCase((string)input);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        string input = "ConvertMe inTo A LowerCase Word pLeAsE";
        string expected = "convertmeIntoALowercaseWordPlease";

        string result = CamelCaseConverter.ConvertToCamelCase((string)input);

        Assert.AreEqual(expected, result);
    }
}
