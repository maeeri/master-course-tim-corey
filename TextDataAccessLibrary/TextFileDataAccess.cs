using TextDataAccessLibrary.Models;
using System.IO;

namespace TextDataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<ContactModel> ReadAllRecords(string textFile)
        {
            var lines = File.ReadAllLines(textFile);
            List<ContactModel> output = new List<ContactModel>();
            foreach (var line in lines) {
                string[] entries = line.Split(',');
                ContactModel c = new ContactModel();
                c.FirstName = entries[0];
                c.LastName = entries[1];
                c.EmailAddresses = [.. entries[2].Split(';')];
                c.PhoneNumbers = [.. entries[3].Split(';')];
                output.Add(c);
            }
            return output;
        }
        public void WriteAllRecords(List<ContactModel> contacts, string textFile)
        {
            List<string> lines = new List<string>();
            foreach (var c in contacts)
            {
                string line = $"{ c.FirstName },{ c.LastName },{ string.Join(';', c.EmailAddresses) },{ string.Join(';', c.PhoneNumbers) }";
                lines.Add(line);
            }

            File.WriteAllLines(textFile, lines);
        }

    }
}
