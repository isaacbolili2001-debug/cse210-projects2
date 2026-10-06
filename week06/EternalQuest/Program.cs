using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        HourlyEmployee hourlyEmployee = new HourlyEmployee();
        hourlyEmployee.SetName("John Doe");
        hourlyEmployee.SetId(1);
        hourlyEmployee.SetDepartment("Sales");
        hourlyEmployee.SetRate(10f);
        hourlyEmployee.SetHours(40f);
        Console.WriteLine($"Hourly Employee Pay: {hourlyEmployee.CalculatePay()}");

        SalariedEmployee salariedEmployee = new SalariedEmployee();
        salariedEmployee.SetName("Jane Smith");
        salariedEmployee.SetId(2);
        salariedEmployee.SetDepartment("Marketing");
        salariedEmployee.SetSalary(2000f);

        Console.WriteLine($"Salaried Employee Pay: {salariedEmployee.CalculatePay()}");
    }

}

public abstract class Employee
{
    private string _name;
    private int _id;
    private string _department;

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }

    public string GetDepartment()
    {
        return _department;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public void SetDepartment(string department)
    {
        _department = department;
    }

    public abstract float CalculatePay();

}

public class HourlyEmployee : Employee
{
    private float _rate = 9f;
    private float _hours = 100f;

    public float GetRate()
    {
        return _rate;
    }

    public void SetRate(float rate)
    {
        _rate = rate;
    }

    public float GetHours()
    {
        return _hours;
    }

    public void SetHours(float hours)
    {
        _hours = hours;
    }

    public override float CalculatePay()
    {
        return _rate * _hours;
    }
}

public class SalariedEmployee : Employee
{
    private float _salary = 1000f;

    public float GetSalary()
    {
        return _salary;
    }

    public void SetSalary(float salary)
    {
        _salary = salary;
    }

    public override float CalculatePay()
    {
        return _salary;
    }
}