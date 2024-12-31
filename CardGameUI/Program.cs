using System;
using System.Text;
using System.Threading.Tasks;
using CardGameUI.Models;

namespace CardGameUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new HeartsDeckModel();
            var hand = deck.DealCards();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
            
            Console.ReadLine();
        }
    }
}
