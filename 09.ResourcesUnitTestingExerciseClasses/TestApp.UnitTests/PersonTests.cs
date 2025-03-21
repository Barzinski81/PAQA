using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void SetUp()
    {
        this._person = new();
    }

    
    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new List<Person>()
        {
            new Person
            {
                Id = "A001",
                Name = "Alice",
                Age = 35
            },
            new Person
            {
                Id = "B002",
                Name = "Bob",
                Age = 30
            }
        };

        // Act
        List<Person> actualPeopleList = this._person.AddPeople(peopleData);

        // Assert
        Assert.That(actualPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < actualPeopleList.Count; i++)
        {
            Assert.That(actualPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(actualPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(actualPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> input = new List<Person>()
        {
            new Person
            {
                Id = "A001",
                Name = "Alice",
                Age = 35
            },
            new Person
            {
                Id = "B002",
                Name = "Bob",
                Age = 30
            }
        };

        string expected = "Bob with ID: B002 is 30 years old."
                          + Environment.NewLine
                          + "Alice with ID: A001 is 35 years old.";

        // Act
        string actual = this._person.GetByAgeAscending(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
