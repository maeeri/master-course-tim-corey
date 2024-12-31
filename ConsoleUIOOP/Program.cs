using ConsoleUIOOP;

string firstName = RequestData.GetAString("Enter your first name: ");

UserMessages.ApplicationStartMessage(firstName);

double x = RequestData.GetADouble("Enter your first number: ");
double y = RequestData.GetADouble("Enter your second number: ");
double result = CalculateData.Add(x, y);

UserMessages.PrintMessage($"The result of adding {x} and {y} is {result}");

Console.ReadLine();