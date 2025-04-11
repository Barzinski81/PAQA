using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string task1 = "Task1";
        DateTime date1 = new DateTime (2025, 04, 11);
        string expected = "To-Do List:"
                         +Environment.NewLine
                         +"[ ] Task1 - Due: 04/11/2025";

        // Act
        _toDoList.AddTask(task1, date1);
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string task1 = "Task1";
        DateTime date1 = new DateTime(2025, 04, 11);
        string expected = "To-Do List:"
                         + Environment.NewLine
                         + $"[✓] Task1 - Due: 04/11/2025";

        // Act
        _toDoList.AddTask(task1, date1);
        _toDoList.CompleteTask(task1);
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string task1 = "Task1";
        
        // Assert
        Assert.That(() => _toDoList.CompleteTask(task1), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // arrange
        string expected = "To-Do List:";

        // act
        string actual = _toDoList.DisplayTasks();

        // assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string task1 = "Task1";
        string task2 = "Task2";
        string task3 = "Task3";
        DateTime date1 = new DateTime(2025, 04, 11);
        DateTime date2 = new DateTime(2024, 03, 25);
        DateTime date3 = new DateTime(2026, 02, 18);
        string expected = "To-Do List:"
                         + Environment.NewLine
                         + $"[ ] Task1 - Due: 04/11/2025"
                         + Environment.NewLine
                         + $"[✓] Task2 - Due: 03/25/2024"
                         + Environment.NewLine
                         + $"[ ] Task3 - Due: 02/18/2026";

        // Act
        _toDoList.AddTask(task1, date1);
        _toDoList.AddTask(task2, date2);
        _toDoList.AddTask(task3, date3);
        _toDoList.CompleteTask(task2);
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
