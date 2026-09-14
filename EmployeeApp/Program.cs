using System;

class Employee
{
    public string FullName;
    public double Salary;

    public void Show()
    {
        Console.WriteLine("ФИО сотрудника: " + FullName);
        Console.WriteLine("Месячная зарплата: " + Salary + " руб.");
    }

    public double CalculateAnnualSalary()
    {
        return Salary * 12;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();

        employee.FullName = "Иванов";
        employee.Salary = 63500;

        employee.Show();

        double annualSalary = employee.CalculateAnnualSalary();

        Console.WriteLine("Годовая зарплата: " + annualSalary + " руб.");
    }
}
