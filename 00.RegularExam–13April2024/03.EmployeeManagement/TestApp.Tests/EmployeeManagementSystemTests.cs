using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class EmployeeManagementSystemTests
{
    private EmployeeManagementSystem _employee;

    [SetUp]
    public void SetUp()
    {
        _employee = new EmployeeManagementSystem();
    }

    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        // Assert
        Assert.That(_employee.EmployeeCount, Is.EqualTo(0));
        CollectionAssert.IsEmpty(_employee.GetAllEmployees());

    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        // Arrange
        string input1 = "Employee1";

        List<string> expected = new List<string>() 
        {
            "Employee1"
        };

        // Act
        _employee.AddEmployee(input1);

        List<string> actual = _employee.GetAllEmployees();

        //Assert
        CollectionAssert.AreEqual(actual, expected);

    }

    [TestCase("")]
    [TestCase(null)]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string input)
    {
        // Act & Assert

        Assert.That(() => _employee.AddEmployee(input), Throws.InstanceOf<ArgumentException>());

    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        // Arrange
        string input1 = "Employee1";
        string input2 = "Employee2";
        string input3 = "Employee3";

        List<string> expected = new List<string>()
        {
            "Employee2",
            "Employee3"
        };

        // Act
        _employee.AddEmployee(input1);
        _employee.AddEmployee(input2);
        _employee.AddEmployee(input3);
        _employee.RemoveEmployee(input1);

        List<string> actual = _employee.GetAllEmployees();

        //Assert
        CollectionAssert.AreEqual(actual, expected);

    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string input)
    {
        // Arrange
        string input1 = "Employee1";
        string input2 = "Employee2";
        string input3 = "Employee3";

        // Act
        _employee.AddEmployee(input1);
        _employee.AddEmployee(input2);
        _employee.AddEmployee(input3);

        // Assert
        Assert.That(() => _employee.RemoveEmployee(input), Throws.InstanceOf<ArgumentException>());
        
    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        // Arrange
        string input1 = "Employee1";
        string input2 = "Employee2";
        string input3 = "Employee3";
        string input4 = "Employee4";
        string input5 = "Employee5";

        List<string> expected = new List<string>()
        {
            "Employee1",
            "Employee2",
            "Employee3",
            "Employee5"
        };

        // Act
        _employee.AddEmployee(input1);
        _employee.AddEmployee(input2);
        _employee.AddEmployee(input3);
        _employee.AddEmployee(input4);
        _employee.AddEmployee(input5);
        _employee.RemoveEmployee(input4);

        List<string> actual = _employee.GetAllEmployees();

        //Assert
        CollectionAssert.AreEqual(actual, expected);
    }   
}

