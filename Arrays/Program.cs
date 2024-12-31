

string[] strings = new string[6];

strings[0] = "Hello";
strings[1] = "World";
strings[2] = "!";
strings[3] = "I";
strings[4] = "am";
strings[5] = "a string array";

Console.WriteLine(strings[0]);

string data = "1,2,3,4,5,6,7";
string[] numbers = data.Split(',');
Console.WriteLine(numbers[^1]);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("For loop: " + numbers[i]);
}
