using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        int n = 0;

        Dictionary<int, int> result = NumberFrequency.CountDigits(n);

        Assert.IsEmpty(result);

    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        int n = 1;
        Dictionary<int, int> expected = new Dictionary<int, int>(n)
        {
            {1, 1 }
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(n);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int n = 1122234456;
        Dictionary<int, int> expected = new Dictionary<int, int>(n)
        {
            {1, 2 },
            {2, 3 },
            {3, 1 },
            {4, 2 },
            {5, 1 },
            {6, 1 },
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(n);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int n = -232323366;

        Dictionary<int, int> expected = new Dictionary<int, int>()
        {
            {2, 3 },
            {3, 4 },
            {6, 2 }
        };

        Dictionary<int, int> result = NumberFrequency.CountDigits(n);

        Assert.AreEqual(expected, result);
    }
}
