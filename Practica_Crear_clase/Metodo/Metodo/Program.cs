using System;

public class Person
{
    
    public Person()
    {
        Name = "Nombre";
    }

   
    public Person(string name)
    {
        Name = name;
    }

    
    public string Name { get; }

    
    public override string ToString()
    {
        return Name;
    }
}
class TestPerson
{
    static void Main()
    {
        
       var person1 = new Person();
       Console.WriteLine(person1.Name);



        var person2 = new Person("Manuel Medina");
        Console.WriteLine(person2.Name);

        


        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}