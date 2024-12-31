
//for (int i = 0; i < 8; i++)
//{
//    Console.WriteLine($"The value of i is {i}");
//}

//string names = "John,Mary,Jane,James";

//List<string> nameList = names.Split(',').ToList();

//for (int i = 0; i < nameList.Count; i++)
//{
//    Console.WriteLine(nameList[i]);
//}

List<decimal> charges = new();
charges.Add(18.45m);
charges.Add(200.00m);
charges.Add(300.00m);

decimal total = 0;

    
//for (int i = 0; i < charges.Count; i++)
//{
//    total += charges[i];
//}

//Console.WriteLine(total);

foreach (var charge in charges)
{
    total += charge;
}


Console.WriteLine(total);