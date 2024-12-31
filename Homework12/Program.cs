using Homework12;

try
{
	MethodClass.DontUseMe();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("Finally block reached.");
}

