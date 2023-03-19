
//#region Task 1 Read Calculator
//Console.WriteLine("===Task 1===");
//Console.WriteLine("Enter first Number: ");
// string firstInput = Console.ReadLine();
//bool parsingFirstInput = int.TryParse(firstInput, out int parsedFirstInput);

//Console.WriteLine("Enter Second Number: ");
//string secondInput = Console.ReadLine();
//bool parsingSecondInput = int.TryParse(secondInput, out int parsedSecondInput);

//Console.WriteLine("Choice matematical operation: ");

//string mathOperation = Console.ReadLine();
//if (parsingFirstInput == false || parsingSecondInput == false)
//{
//    Console.WriteLine("Your input is not parsed!");
//}

//if (mathOperation != "+" &&  mathOperation != "-" && mathOperation != "*" && mathOperation != "/")
//{
//    Console.WriteLine("Invalid operation!!!");
//} 

//if (mathOperation == "+")
//{
//    Console.WriteLine($"The result is:{parsedFirstInput + parsedSecondInput}");
//}
//else if (mathOperation == "-")
//{
//    Console.WriteLine($" The result is: {parsedFirstInput - parsedSecondInput}");
//}
//else if (mathOperation == "*")
//{
//    Console.WriteLine($" The result is: {parsedFirstInput * parsedSecondInput}");
//}
//else if (mathOperation == "/")
//{
//    Console.WriteLine($" The result is: {parsedFirstInput / parsedSecondInput}");
//}

#endregion
#region Task 2 AverageNumber
Console.WriteLine("===Task 2===");
Console.WriteLine("Enter first Number: ");
bool firstNumber = int.TryParse(Console.ReadLine(), out int parsedFirstNumber);
Console.WriteLine("Enter second Number: ");
bool secondNumber = int.TryParse(Console.ReadLine(), out int parsedSecondNumber);
Console.WriteLine("Enter third Number: ");
bool thirdNumber = int.TryParse(Console.ReadLine(), out int parsedThirdNumber);
Console.WriteLine("Enter four Number: ");
bool fourNumber = int.TryParse(Console.ReadLine(), out int parsedFourNumber);
if (firstNumber == false || secondNumber == false || thirdNumber == false || fourNumber == false)
{
    Console.WriteLine("Your input is not parsed!");
}  

Console.WriteLine($"The AvarageNumber  is: {(parsedFirstNumber + parsedSecondNumber + parsedThirdNumber + parsedFourNumber)/4}");
#endregion
#region Task3 SwapNumbers
Console.WriteLine("===Task 3===");
Console.WriteLine("Enter first Number: ");
bool firstSwapNumber = int.TryParse(Console.ReadLine(), out int parsedfirstSwapNumber);
bool secondSwapNumber = int.TryParse(Console.ReadLine(), out int parsedsecondSwapNumber);

if(firstSwapNumber == false && secondSwapNumber == false)
{
    Console.WriteLine("Your input is not parsed!");
}

Console.WriteLine("Expected results after swaping!!!");
int parsedsecondSwapNumber2 = 0;
parsedfirstSwapNumber = parsedsecondSwapNumber;
parsedsecondSwapNumber = parsedsecondSwapNumber2;
Console.WriteLine($"First swapedNumber is: {parsedfirstSwapNumber}");
Console.WriteLine($"Second swapedNumber is: {parsedsecondSwapNumber}");

#endregion
