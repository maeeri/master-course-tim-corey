

using Methods;

//string name = ConsoleActions.AskFirstName();


//ConsoleActions.SayHi(name);

//for (int i = 0; i < 10; i++)
//{
//    Console.Write(".");
//    Task.Delay(200).Wait();
//}

//Console.WriteLine();
//ConsoleActions.SayGoodbye();

//MathShortcuts.Add(3, 5);

//MathShortcuts.AddAll(new double[] { 1, 2, 3, 4, 5 });

(string firstName, string lastName) = ConsoleActions.GetFullName();

Console.WriteLine($"Your name is {firstName} {lastName}");

