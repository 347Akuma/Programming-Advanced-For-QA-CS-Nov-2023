using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        Dictionary<string, int> input2 = new Dictionary<string, int>();

        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);

        //Assert
        Assert.IsEmpty(actual);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        input1.Add("a", 1);
        input1.Add("b", 2);
        Dictionary<string, int> input2 = new Dictionary<string, int>();

        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);

        //Assert
        Assert.IsEmpty(actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        input1.Add("a", 1);
        input1.Add("b", 2);
        Dictionary<string, int> input2 = new Dictionary<string, int>();
        input2.Add("c", 1);
        input2.Add("d", 2);

        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);

        //Assert
        Assert.IsEmpty(actual);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        input1.Add("a", 1);
        input1.Add("b", 2);
        input1.Add("d", 4);
        input1.Add("g", 250);
        input1.Add("f", 50);
        Dictionary<string, int> input2 = new Dictionary<string, int>();
        input2.Add("c", 3);
        input2.Add("d", 4);
        input2.Add("a", 1);
        input2.Add("g", 251);
        input2.Add("h", 250);
        input2.Add("f", 50);

        Dictionary<string, int> expected = new Dictionary<string, int>();
        expected.Add("a", 1);
        expected.Add("d", 4);
        expected.Add("f", 50);

        //Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);

        //Assert
        Assert.That(actual, Is.EquivalentTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> input1 = new Dictionary<string, int>();
        input1.Add("a", 1);
        input1.Add("b", 2);
        input1.Add("d", 5);
        input1.Add("h", 250);
        Dictionary<string, int> input2 = new Dictionary<string, int>();
        input2.Add("c", 3);
        input2.Add("d", 4);
        input2.Add("a", 10);
        input2.Add("h", 69);

        Dictionary<string, int> expected = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> actual = DictionaryIntersection.Intersect(input1, input2);

        //Assert
        Assert.AreEqual(actual, expected);

    }
}
