using System;
using System.Collections.Generic;

namespace TestApp;

public class EmployeeManagementSystem
{
    private List<string> employees;

    public EmployeeManagementSystem()
    {
        employees = new List<string>();
    }

    public int EmployeeCount { get => employees.Count; }

    public void AddEmployee(string employeeName)
    {
        if (string.IsNullOrWhiteSpace(employeeName))
        {
            throw new ArgumentException("Employee name cannot be empty or whitespace.");
        }

        employees.Add(employeeName);
    }

    public void RemoveEmployee(string employeeName)
    {
        if (!employees.Contains(employeeName))
        {
            throw new ArgumentException("Employee not found in the system.");
        }

        employees.Remove(employeeName);
    }

    public List<string> GetAllEmployees()
    {
        return employees;
    }
}

