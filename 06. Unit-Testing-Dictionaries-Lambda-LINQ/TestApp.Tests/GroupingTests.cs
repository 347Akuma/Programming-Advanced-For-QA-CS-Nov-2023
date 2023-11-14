using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> ints = new List<int>();

        // Act
        string result  = Grouping.GroupNumbers(ints);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        
        //Arrange
        List<int> ints = new () { 1, 2, 3, 4};
        string expected = "Odd numbers: 1, 3\r\nEven numbers: 2, 4";

        //Act
        string result = Grouping.GroupNumbers(ints);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        //Arrange
        List<int> ints = new() { 2, 4, 6 };
        string expected = "Even numbers: 2, 4, 6";

        //Act
        string result = Grouping.GroupNumbers(ints);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        //Arrange
        List<int> ints = new() { 1, 3, 5 };
        string expected = "Odd numbers: 1, 3, 5";

        //Act
        string result = Grouping.GroupNumbers(ints);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        //Arrange
        List<int> ints = new() { -1, -3, -5 };
        string expected = "Odd numbers: -1, -3, -5";

        //Act
        string result = Grouping.GroupNumbers(ints);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
