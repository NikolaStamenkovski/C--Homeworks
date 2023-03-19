using Exercise2;


Console.WriteLine("Please fill out the following information about the dog!");
Console.WriteLine("Enter your Dog Name:");
string dogName = Console.ReadLine();

if (dogName == "")
{
    Console.WriteLine("You have to insert your Dogs Name!");
    return;
}
else if (int.TryParse(dogName, out int value))
{
    Console.WriteLine("You cannot insert a number for Dogs name!");
    return;
}

Console.WriteLine("Enter your Dog Race:");
string dogRace = Console.ReadLine();

if (dogRace == "")
{
    Console.WriteLine("You have to insert your Dogs Race!");
    return;
}
else if (int.TryParse(dogRace, out int value))
{
    Console.WriteLine("You cannot insert a number for Dogs race!");
    return;
}

Console.WriteLine("Enter your Dog Color:");
string dogColor = Console.ReadLine();

if (dogColor == "")
{
    Console.WriteLine("You have to insert your Dogs Color!");
    return;
}
else if (int.TryParse(dogColor, out int value))
{
    Console.WriteLine("You cannot insert a number for Dogs Color!");
    return;
}
Dog dog = new Dog(dogName, dogRace, dogColor);

Console.WriteLine("===========");

while (true)
{
    Console.Write("Please select one of the offered actions- Eat, Play or Chase-Tail >");
    string inputMethod = Console.ReadLine().ToLower();

    if (inputMethod == "eat")
    {
        dog.Eat();
        break;
    }
    else if (inputMethod == "play")
    {
        dog.Play();
        break;
    }
    else if (inputMethod == "chase-tail")
    {
        dog.ChaseTail();
        break;
    }
    else
    {
        Console.WriteLine("Please select one of the options offered");
    }
}
