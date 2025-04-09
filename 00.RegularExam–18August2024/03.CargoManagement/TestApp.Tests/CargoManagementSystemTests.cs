using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using NUnit.Framework.Constraints;

namespace TestApp.Tests;

[TestFixture]
public class CargoManagementSystemTests
{

    private CargoManagementSystem _cargo = null!;

    [SetUp]
    public void SetUp()
    {
        _cargo = new CargoManagementSystem();
    }

    [Test]
    public void Test_Constructor_CheckInitialEmptyCargoCollectionAndCount()
    {
        // Assert
        CollectionAssert.IsEmpty(_cargo.GetAllCargos());
        Assert.That(_cargo.CargoCount, Is.EqualTo(0));

    }

    [Test]
    public void Test_AddCargo_ValidCargoName_AddNewCargo()
    {
        // Arrange
        string input = "Cargo1";
        List<string> expected = new List<string> 
        {
            "Cargo1"        
        };

        // Act
        _cargo.AddCargo(input);
        List<string> actual = _cargo.GetAllCargos();

        // Assert
        CollectionAssert.AreEqual(expected, actual);

    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_AddCargo_NullOrEmptyCargoName_ThrowsArgumentException(string input)
    {    
        // Act & Assert
        Assert.That(() => _cargo.AddCargo(input), Throws.TypeOf<ArgumentException>());

    }

    [Test]
    public void Test_RemoveCargo_ValidCargoName_RemoveFirstCargoName()
    {
        // Arrange
        string input1 = "Cargo1";
        string input2 = "Cargo2";
        string input3 = "Cargo3";
        List<string> expected = new List<string>
        {
            "Cargo2",
            "Cargo3"
        };

        // Act
        _cargo.AddCargo(input1);
        _cargo.AddCargo(input2);
        _cargo.AddCargo(input3);
        _cargo.RemoveCargo(input1);
        List<string> actual = _cargo.GetAllCargos();

        // Assert
        CollectionAssert.AreEqual(expected, actual);

    }

    [TestCase(null)]
    [TestCase("")]
    [Test]
    public void Test_RemoveCargo_NullOrEmptyCargoName_ThrowsArgumentException(string input)
    {
        // Arrange
        string input1 = "Cargo1";
        string input2 = "Cargo2";
        string input3 = "Cargo3";
        
        _cargo.AddCargo(input1);
        _cargo.AddCargo(input2);
        _cargo.AddCargo(input3);
              
        // Act & Assert
        Assert.That(() => _cargo.RemoveCargo(input), Throws.TypeOf<ArgumentException>());

    }

    [Test]
    public void Test_GetAllCargos_AddedAndRemovedCargos_ReturnsExpectedCargoCollection()
    {
        // Arrange
        string input1 = "Cargo1";
        string input2 = "Cargo2";
        string input3 = "Cargo3";
        string input4 = "Cargo4";
        string input5 = "Cargo5";

        List<string> expected = new List<string>
        {
            "Cargo2",
            "Cargo3",
            "Cargo5"
        };

        // Act
        _cargo.AddCargo(input1);
        _cargo.AddCargo(input2);
        _cargo.AddCargo(input3);
        _cargo.AddCargo(input4);
        _cargo.AddCargo(input5);
        _cargo.RemoveCargo(input1);
        _cargo.RemoveCargo(input4);
        List<string> actual = _cargo.GetAllCargos();

        // Assert
        CollectionAssert.AreEqual(expected, actual);

    }
}

    