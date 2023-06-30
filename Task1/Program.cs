List<Person> persons = new List<Person>();
for (int i = 1; i <= 3; i++)
{
    Person person = new Person()
    {
        Name = Console.ReadLine()
    };
    persons.Add(person);
}
foreach (var person in persons)
{
    System.Console.WriteLine($"Hello! My name is {person.Name}");
}
Person person1 = new Person();
System.Console.WriteLine(person1.ToString());


class Person
{
    public string Name;
}