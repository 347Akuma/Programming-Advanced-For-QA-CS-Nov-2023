using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = Plants.GetFastestGrowing(input);

        //Assert
        Assert.IsEmpty(result);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "george the plant" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 16 letters:\r\ngeorge the plant"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "idiot plant", "george the plant" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 11 letters:\r\nidiot plant\r\nPlants with 16 letters:\r\ngeorge the plant"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "iDiot pl@nt", "Ge0rgE tHE pl@nt" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 11 letters:\r\niDiot pl@nt\r\nPlants with 16 letters:\r\nGe0rgE tHE pl@nt"));
    }
}
