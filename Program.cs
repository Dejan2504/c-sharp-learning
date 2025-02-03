
class Person {
    public string Name {get; set;} = "jebigaa";
    public int Age {get; set;}

    public Person(string name, int age){

        Name = name;
        Age = age;
    }
}

class Program
{

public static void Main(string[] args){
    Person newPerson = new Person("Dejan", 12){
        Age = 42
    };

    // newPerson.Age = 23;
    Console.WriteLine(newPerson.Age);
    }    
}


// See https://aka.ms/new-console-template for more information

