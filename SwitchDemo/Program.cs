

string firstName = "";
int age = 20;

bool isStudent = false;
bool isSenior = age > 65;


switch (firstName.ToLower())
{
    case "john":
        Console.WriteLine(isStudent ? "Hello John. You are a student" : "Hello, John. You are not a student");
        break;
    case "mary":
        Console.WriteLine("Hello Mary");
        break;
    default:
        Console.WriteLine("Hello Stranger");
        break;
}


switch (age % 2)
{
    case 0:
        Console.WriteLine("000");
        break;
    case 1:
        Console.WriteLine("111");
        break;
    default:
        Console.WriteLine("???");
        break;
}