using Newtonsoft.Json.Linq;
using NUnit.Framework;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
        string input = "TestString";
        string expected = "gnirtStseT";

        // Act
        string actual = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal price = 100;
        decimal discount = 20;
        decimal expected = 80;

        // Act
        decimal actual = this._exceptions.ArgumentCalculateDiscount(price, discount);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 100;
        decimal discount = -20;
    
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(price, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 100;
        decimal discount = 200;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(price, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
        int index = 4;
        int expected = 5;

        // Act 
        int actual = this._exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
        int index = -4;
       
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
        int index = array.Length + 2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool logged = true;
        string expected = "User logged in.";
        // Act
        string actual = this._exceptions.InvalidOperationPerformSecureOperation(logged);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool logged = false;

        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(logged), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "134";
        int expected = 134;

        // Act 
        int actual = this._exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "xyz4";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["five"] = 5,
            ["ten"] = 10
        };
        string key = "five";
        int expected = 5;

        // Act
        int actual = this._exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["five"] = 5,
            ["ten"] = 10
        };
        string key = "nine";

        // Act & Assert
        Assert.That(() => this._exceptions.KeyNotFoundFindValueByKey(dictionary, key),Throws.TypeOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 2048;
        int b = 32;
        int expected = a + b;

        // Act
        int actual = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 32;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), 
            Throws.TypeOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -32;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b), 
            Throws.TypeOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int divident = 64;
        int divisor = 8;
        int expected = 8;

        // Act
        int actual = this._exceptions.DivideByZeroDivideNumbers(divident, divisor);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int divident = 64;
        int divisor = 0;
       

        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(divident, divisor), Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int index = 2;
        int expected = input.Sum(i => i);

        // Act
        int actual = this._exceptions.SumCollectionElements(input, index);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] input = null;
        int index = 2;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.TypeOf<ArgumentNullException>());
        
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4, 5 };
        int index = 7;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index), Throws.TypeOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            ["one"] = "1",
            ["two"] = "2",
            ["three"] = "3"

        };
        string key = "two";
        int expected = 2;

        // Act
        int actual = this._exceptions.GetElementAsNumber(input, key);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            ["one"] = "1",
            ["two"] = "2",
            ["three"] = "3"

        };
        string key = "five";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), Throws.TypeOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            ["one"] = "1a",
            ["two"] = "2b",
            ["three"] = "3c"

        };
        string key = "two";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key), 
            Throws.TypeOf<FormatException>());
    }
}
