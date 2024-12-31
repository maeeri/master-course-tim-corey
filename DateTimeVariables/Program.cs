using System.Globalization;

DateTime today = DateTime.UtcNow;

DateTime birthday = DateTime.ParseExact("20.7.2024", "d.M.yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(today.ToString("MMMM dd, yyyy HH:mm zzz"));

