// See https://aka.ms/new-console-template for more information
using EmailSenderTest;
using System.Net.Mail;

Console.WriteLine("Hello, World!");
SmtpHelper.SendMessage("Test", "mari-anne.eerikainen@roimaint.com", "Test message", false);
Console.WriteLine("Email sent?");

Console.ReadKey();
