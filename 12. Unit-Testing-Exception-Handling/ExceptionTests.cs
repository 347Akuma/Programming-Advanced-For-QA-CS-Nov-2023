using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Please don't reverse me!";
        string expected = "!em esrever t'nod esaelP";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null!;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        //Arrange
        decimal price = 50;
        decimal discount = 100;
        decimal expected = 0;

        //Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(price, discount);

        //Assert
        Assert.That(result, Is.EqualTo((decimal)expected));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 50;
        decimal discount = -5;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        int[] numbers = { 1, 2, 3 };
        int index = 2;


        //Act
        int result = this._exceptions.IndexOutOfRangeGetElement(numbers, index);


        //Assert
        Assert.AreEqual(3, result);
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4 };
        int index = -2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 5;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        //Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";


        //Act
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        //Arrange
        bool isLoggedIn = false;


        //Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        //Arrange
        string input = "12";

        //Act
        int result = this._exceptions.FormatExceptionParseInt(input);


        //Assert
        Assert.That(result, Is.EqualTo((int)12));
        Assert.That(result, Is.TypeOf<Int32>());
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        //Arrange
        string input = "1dvanaise2";

        //Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        //Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("a", 1);
        input.Add("b", 2);
        input.Add("c", 3);

        string key = "b";

        int expected = 2;

        //Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(input, key);

        //Assert
        Assert.AreEqual(expected, result);

    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, int> input = new Dictionary<string, int>();
        input.Add("a", 1);
        input.Add("b", 2);
        input.Add("c", 3);

        string key = "g";

        //Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        //Arrange
        int a = 1;
        int b = 2;

        int expected = 3;

        //Act
        int result = this._exceptions.OverflowAddNumbers(a, b);

        //Assert
        Assert.AreEqual((int)expected, result);
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        //Arrange
        int a = int.MaxValue;
        int b = 2;

        //Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {

        //Arrange
        int a = int.MinValue;
        int b = -2;

        //Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        //Arrange
        int toDivide = 20;
        int divisor = 5;

        int expected = 4;

        //Act
        int result = this._exceptions.DivideByZeroDivideNumbers(toDivide, divisor);

        //Assert
        Assert.AreEqual((int)expected, result);
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        //Arrange
        int toDivide = 20;
        int divisor = 0;

        //Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(toDivide, divisor), Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        //Arrange
        int[] input = { 1, 2, 3, 4, 5, 6 };
        int index = 5;

        int expected = 21;

        //Act
        int result = this._exceptions.SumCollectionElements(input, index);

        //Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        //Arrange
        int[] input = null;
        int index = 5;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.InstanceOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        //Arrange
        int[] input = { 1, 2, 3, 4, 5, 6 };
        int index = 12;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        //Arrange
        Dictionary<string, string> input = new Dictionary<string, string>();
        input.Add("one", "1");
        input.Add("two", "2");
        input.Add("three", "3");

        string key = "two";

        int expected = (int)2;


        //Act
        int result = this._exceptions.GetElementAsNumber(input, key);

        //Assert
        Assert.AreEqual(expected, result);
        Assert.That(result, Is.TypeOf<int>());
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        //Arrange
        Dictionary<string, string> input = new Dictionary<string, string>();
        input.Add("one", "1");
        input.Add("two", "2");
        input.Add("three", "3");

        string key = "seven";

        //Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        //Arrange
        Dictionary<string, string> input = new Dictionary<string, string>();
        input.Add("one", "1");
        input.Add("two", "boom");
        input.Add("three", "3");

        string key = "two";

        //Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<FormatException>());
    }
}
