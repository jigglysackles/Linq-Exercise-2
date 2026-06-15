using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise;

internal class Program
{
    //Static array of integers
    private static readonly int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

    private static void Main(string[] args)
    {
        /*
         *
         * Complete every task using Method OR Query syntax.
         * You may find that Method syntax is easier to use since it is most like C#
         * Every one of these can be completed using Linq and then printing with a foreach loop.
         * Push to your github when completed!
         *
         */

        //TODO: Print the Sum of numbers
        var sumNumbers = numbers.Sum();
        Console.WriteLine("\n+== Sum of Numbers ==+");
        Report.Out(sumNumbers);

        //TODO: Print the Average of numbers
        var avgNumbers = numbers.Average();
        Console.WriteLine("\n+== Average of Numbers ==+");
        Report.Out(avgNumbers);

        //TODO: Order numbers in ascending order and print to the console
        var ascNumbers = numbers.OrderBy(x => x).ToList();
        Console.WriteLine("\n+== Ascending Numbers ==+");
        Report.Out(ascNumbers);

        //TODO: Order numbers in descending order and print to the console
        var descNumbers = numbers.OrderByDescending(x => x).ToList();
        Console.WriteLine("\n+== Descending Numbers ==+");
        Report.Out(descNumbers);

        //TODO: Print to the console only the numbers greater than 6
        var overSixNumbers = numbers.Where(x => x > 6).ToList();
        Console.WriteLine("\n+== Numbers Greater than Six ==+");
        Report.Out(overSixNumbers);

        //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
        var fourDescNumbers = descNumbers.GetRange(0, 4);
        Console.WriteLine("\n+== Four Descending numbers ==+");
        Report.Out(fourDescNumbers);

        //TODO: Change the value at index 4 to your age, then print the numbers in descending order
        numbers[4] = 42;
        descNumbers = numbers.OrderByDescending(x => x).ToList();
        Console.WriteLine("\n+== Swapped index[4] value of 5 for Age ==+");
        Report.Out(descNumbers);

        // List of employees ****Do not remove this****
        var employees = CreateEmployees();

        //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
        var fullNameOfCAndS = employees.Where(x => x.FirstName.StartsWith('S') || x.FirstName.StartsWith('C'))
            .OrderBy(x => x.FirstName).ToList();
        Console.WriteLine("\n+== Full Name starting with C or S sorted by Ascending First Name ==+");
        Report.Out(fullNameOfCAndS);


        //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
        var fullNameOver26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName).ToList();
        Console.WriteLine("\n+== Full Name and Age > 26, ordered by Age and First Name ==+");
        Report.Out(fullNameOver26);

        //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
        var yOELessThan10AgeMoreTham35 = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
        var sumYOE = 0;
        foreach (var x in yOELessThan10AgeMoreTham35) sumYOE += x.YearsOfExperience;
        Console.WriteLine("\n+== Sum of YOE when YOE <= 10 and Age > 35 ==+");
        Report.Out(sumYOE);

        //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
        var count = yOELessThan10AgeMoreTham35.Count();
        var avgYOE = sumYOE / count;
        Console.WriteLine("\n+== Average of YOE when YOE <= 10 and Age > 35 ==+");
        Report.Out(avgYOE);

        //TODO: Add an employee to the end of the list without using employees.Add()
        var newArrayLength = employees.Count + 1;
        var arr = employees.ToArray();
        Array.Resize(ref arr, newArrayLength);
        arr[newArrayLength - 1] = new Employee("PowderedToast", "Man", 37, 10);
        employees = arr.ToList();
        Console.WriteLine("\n+== Added a new Employee without using .Add() ==+");
        Report.Out(employees);


        Console.WriteLine();

        Console.ReadLine();
    }

    #region CreateEmployeesMethod

    private static List<Employee> CreateEmployees()
    {
        var employees = new List<Employee>();
        employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
        employees.Add(new Employee("Steven", "Bustamento", 56, 5));
        employees.Add(new Employee("Micheal", "Doyle", 36, 8));
        employees.Add(new Employee("Daniel", "Walsh", 72, 22));
        employees.Add(new Employee("Jill", "Valentine", 32, 43));
        employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
        employees.Add(new Employee("Big", "Boss", 23, 14));
        employees.Add(new Employee("Solid", "Snake", 18, 3));
        employees.Add(new Employee("Chris", "Redfield", 44, 7));
        employees.Add(new Employee("Faye", "Valentine", 32, 10));

        return employees;
    }

    #endregion
}