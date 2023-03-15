using Operator_overloading;

Person human1 = new Person()
{
    name = "Ulvi",
    surname = "Kerimov",
    age = 49
};
Person human2 = new Person()
{
    name = "Miribrahim",
    surname = "Kerimov",
    age = 10
};
Person human3 = new Person()
{
    name = "Sadiq",
    surname = "Selimov",
    age = 29
};
Person[] p1 = new Person[] { human1, human2, human3 };

for (int i = 0; i < p1.Length; i++)
{
    for (int j = i + 1; j < p1.Length; j++)
    {
        if (p1[i].age > p1[j].age)
        {
            p1[i].age = p1[j].age + p1[i].age;
            p1[j].age = p1[i].age - p1[j].age;
            p1[i].age = p1[i].age - p1[j].age;
        }
    }
}
foreach (var item in p1)
{
    Console.WriteLine(item.age);
}
