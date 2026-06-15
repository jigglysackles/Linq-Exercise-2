namespace LinqExercise;

internal class Employee
{
    public Employee(string firstName, string lastName, int age, int yearsOfExperience)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        YearsOfExperience = yearsOfExperience;
    }

    public Employee()
    {
    }

    public int Age { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public int YearsOfExperience { get; set; }
}