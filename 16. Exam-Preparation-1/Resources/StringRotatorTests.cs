using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        int positions = 2;


        //Act
        string result = StringRotator.RotateRight(input, positions);


        //Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "12345";
        int positions = 0;

        string expected = "12345";


        //Act
        string result = StringRotator.RotateRight(input, positions);


        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdefghijk";
        int positions = 6;

        string expected = "fghijkabcde";


        //Act
        string result = StringRotator.RotateRight(input, positions);


        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdefghijk";
        int positions = -6;

        string expected = "fghijkabcde";


        //Act
        string result = StringRotator.RotateRight(input, positions);


        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "abcdefghijk";
        int positions = 20;

        string expected = "cdefghijkab";


        //Act
        string result = StringRotator.RotateRight(input, positions);


        //Assert
        Assert.AreEqual(expected, result);
    }
}
