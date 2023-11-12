using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "www.fakeURL!!!!,";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "This is a valid URL: https://smokeweed.com";
        List<string> expected = new () { "https://smokeweed.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {      
        {
            // Arrange
            string text = "This is a valid URL: https://smokeweed.com, This is a valid one too: https://whatisgoingon.com";
            List<string> expected = new() { "https://smokeweed.com", "https://whatisgoingon.com" };

            // Act
            List<string> result = MatchUrls.ExtractUrls(text);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "This is a valid URL: \"https://smokeweed.com\", This is a valid one too: \"https://whatisgoingon.com\"";
        List<string> expected = new() { "https://smokeweed.com", "https://whatisgoingon.com" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
