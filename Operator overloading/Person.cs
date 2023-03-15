namespace Operator_overloading;

public class Person
{
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }

    public static bool operator >(Person a, Person b)
    {
        return a.age > b.age;
    }
    public static bool operator <(Person a, Person b)
    {
        return a.age < b.age;
    }
}
