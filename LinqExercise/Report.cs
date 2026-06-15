using System;
using System.Collections.Generic;

namespace LinqExercise;

public class Report
{
    public static void Out(int[] arr)
    {
        foreach (var e in arr) Console.WriteLine(e);
    }

    public static void Out(double[] arr)
    {
        foreach (var e in arr) Console.WriteLine(e);
    }

    public static void Out(List<int> arr)
    {
        foreach (var e in arr) Console.WriteLine(e);
    }

    public static void Out(List<string> arr)
    {
        foreach (var e in arr) Console.WriteLine(e);
    }

    internal static void Out(List<Employee> employeeList)
    {
        foreach (var e in employeeList) Console.WriteLine(e.FullName);
    }

    public static void Out(int n)
    {
        Console.WriteLine(n);
    }

    public static void Out(double n)
    {
        Console.WriteLine(n);
    }

    public static void Out(decimal n)
    {
        Console.WriteLine(n);
    }
}