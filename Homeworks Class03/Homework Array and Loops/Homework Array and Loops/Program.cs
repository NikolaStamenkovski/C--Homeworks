Console.WriteLine("Exercise");
#region Exercise 4
Console.WriteLine("===Words===");
string[] arrayWithwords = new string[] { "Nikola", "Stamenkovski", "Student", "On", "SEDC" };
foreach (string word in arrayWithwords)
{

    Console.WriteLine(word);
}
Console.WriteLine("===Decimal number===");
decimal[] arrayWithDecimals = new decimal[] { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m };
foreach (decimal decimalNumber in arrayWithDecimals)
{
    Console.WriteLine(decimalNumber);
}
char[] arrayWithCharacters = new char[] { 't', 'a', 's', 'k', '1' };
Console.WriteLine("===Character===");
foreach (char charCharacter in arrayWithCharacters)
{
    Console.WriteLine(charCharacter);
}
Console.WriteLine("===Boolean===");
bool[] arrayWithBoolean = new bool[5];
arrayWithBoolean[0] = (5 > 3);
arrayWithBoolean[1] = (5 > 4);
arrayWithBoolean[2] = 2 == 2;
arrayWithBoolean[3] = (0 != 0);
arrayWithBoolean[4] = (6 < 5);

foreach (bool boolean in arrayWithBoolean)
{
    Console.WriteLine(boolean);
}
Console.WriteLine("===Arrays==="); // Ovoj task go rzabrav kako niza vo niza da kreiram so celi broevi.. Ko primercheto od chas.. KOga probav da go vrat so foreach mi dade deka ne prifakja integer pa staviv var ( i za toa neshto kazhavte)
int[][] arrayOfArrays = new int[][]
{
    new int[] {555, 444},
    new int[] {666, 333},
    new int[] {777, 222},
    new int[] {888, 111},
    new int[] {999, 1000}
};
foreach (var arayItem in arrayOfArrays)
{
    foreach (var aray in arayItem)
    {
        Console.WriteLine(aray);
    }
}
#endregion
#region Exercise 5
Console.WriteLine("Write 5 random numbers:");

int[] arryOfInsertedNumbers = new int[5];
int sum = 0;
for (int i = 0; i < arryOfInsertedNumbers.Length; i++)
{
    bool Input = false;

    while (!Input)
    {

        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {
            arryOfInsertedNumbers[i] = number;
            Input = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");

        }
    }
}
for (int i = 0; i < arryOfInsertedNumbers.Length; i++)
{
    sum += arryOfInsertedNumbers[i];
}
Console.WriteLine("The sum of all inserted numbers is " + sum);
foreach (int number in arryOfInsertedNumbers)
{
    Console.Write(number + " ");
}
// Sakav da gi isprinatam ko niza so [] zagradi ama ne mi uspea!!!

#endregion

#region Exercise 6

string[] arrayOfInsertedNames = new string[0];
string nameInput;

for (; ; )
{
    Console.WriteLine("Enter a name :");
    nameInput = Console.ReadLine();

    Array.Resize(ref arrayOfInsertedNames, arrayOfInsertedNames.Length + 1);
    arrayOfInsertedNames[arrayOfInsertedNames.Length - 1] = nameInput;


    string continueInput;
    for (; ; )
    {
        Console.Write("Press 'Y' to add onther name in Array, or pres 'N' to end the array ");
        continueInput = Console.ReadLine().ToUpper();

        if (continueInput == "Y" || continueInput == "N")
        {
            break;
        }
        else
        {
            Console.WriteLine("You must enter 'Y' or 'N'.");
        }

    }

    if (continueInput.ToUpper() == "N")
    {
        break;
    }
}


foreach (string name in arrayOfInsertedNames)
{

    Console.Write(name + " ");
}


#endregion

#region Task 1
Console.WriteLine("Write 6 numbers:");

int[] randomNumbers = new int[6];
int SumOfEvenNumbers = 0;
// recomended Numbers 4, 3 , 7, 3, 2, 8
//expected result 14

for (int i = 0; i < randomNumbers.Length; i++)
{

    bool input = false;

    while (!input)
    {

        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int number))
        {

            randomNumbers[i] = number;
            input = true;
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}

for (int i = 0; i < randomNumbers.Length; i++)
{
    if (randomNumbers[i] % 2 == 0)
    {
        SumOfEvenNumbers += randomNumbers[i];
    }
}

Console.WriteLine("Result is: " + SumOfEvenNumbers);


#endregion

#region Task 2 
string[] studentsG1 = new string[] { "Nikola", "Dimitar", "Dragisha", "Mitko", "Mice" };
string[] studentsG2 = new string[] { "Tomo", "Sanja", "Simon", "Dejan", "Angel" };


for (; ; )
{
    Console.WriteLine("Choice between 1 and 2 to get data from the same group");
    bool isTheInputParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isTheInputParsed)
    {
        if (number == 1)
        {
            Console.WriteLine("Students from Fisrt Group - G1");
            foreach (string student in studentsG1)
            {
                Console.WriteLine(student);
            }
            break;

        }
        else if (number == 2)
        {
            Console.WriteLine("Students from Second Group - G2");
            foreach (string student in studentsG2)
            {
                Console.WriteLine(student);
            }
            break;
        }
        else
        {
            Console.WriteLine("Insert one of recomended choices to get info about the groups.");
        };
    }
};
#endregion