using UserModel;

static void NewMethod(string name = "default"){
    Console.WriteLine($"Bice nesto i od {name}...");
}

Console.WriteLine("Hello, World!");
 User.AddOne();
 User.AddOne();
 User.AddOne();

 NewMethod("user1");
 NewMethod("user2");
 NewMethod();

 int number = User.GetNum();


Console.WriteLine($"This is my number {number}");

// See https://aka.ms/new-console-template for more information

