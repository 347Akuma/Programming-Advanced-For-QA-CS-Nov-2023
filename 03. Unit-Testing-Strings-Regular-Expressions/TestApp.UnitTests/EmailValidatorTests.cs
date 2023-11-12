using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    // TODO: finish the test
    [TestCase("adimitrovx@gmail.com")]
    [TestCase("adimitrovx@hotmail.co.uk")]
    [TestCase("adimitrovx@fakemail.gov.za")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    // TODO: finish the test
    [TestCase("adimitrovx-gmail.com")]
    [TestCase("adimitrovx.at.hotmail.co")]
    [TestCase("adimitrovxXx.Gmail.com")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
