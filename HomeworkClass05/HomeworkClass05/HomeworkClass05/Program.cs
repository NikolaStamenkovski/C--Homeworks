using HomeworkClass05.Clasess;
using System.IO.Pipes;
//   ● Create a class Human
//   ● Add properties: FirstName, LastName, Age
//   ● Create a method called GetPersonStats that returns the full name of the human as well as their age
//   ● Create an object human by asking the user to fill the required information
//   ● Call the GetPersonStats method and print the result in the console after the object is created



Console.WriteLine("Please fill out the following information about you!");
Console.WriteLine("First Name:");
string firstName = Console.ReadLine();

if (firstName == "")
{
    Console.WriteLine("You have to insert your First Name!");
    return;
}
else if (int.TryParse(firstName, out int value))
{
    Console.WriteLine("You cannot insert a number for First Name!");
    return;
}

Console.WriteLine("Last Name:");
string lastName = Console.ReadLine();

if (lastName == "")
{
    Console.WriteLine("You have to insert your Last Name!");
    return;
}
else if (int.TryParse(lastName, out int value))
{
    Console.WriteLine("You cannot insert a number for Last Name!");
    return;
}

Console.WriteLine("Age:");
string age = Console.ReadLine(); 

if (age == "")
{
    Console.WriteLine("You have to insert your age!");
    return;
}
else if (!int.TryParse(age, out int value)) 
{
    Console.WriteLine("You need to insert a number for the age - field!");
    return;
}

Human person = new Human(firstName, lastName, age);

Console.WriteLine(person.GetPersonStats());



      