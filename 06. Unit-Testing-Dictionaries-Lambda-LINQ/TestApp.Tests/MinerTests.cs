using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "gOlD 8", "sILVEr 30" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = { "sr3br0 8", "zl@to 30","pl@t!n@ 40" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"sr3br0 -> 8\r\nzl@to -> 30\r\npl@t!n@ -> 40"));
    }
}
