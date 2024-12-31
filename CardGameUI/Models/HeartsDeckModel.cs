using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI.Models
{
    public class HeartsDeckModel : DeckModel
    {
        public HeartsDeckModel()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            var output = new List<PlayingCardModel>();
            for (int i = 0; i < 13; i++)
            {
                output.Add(DrawOneCard());
                drawPile.Remove(output.Last());
            }
            foreach (var card in drawPile)
            {
                Console.WriteLine(card.Suit + " " + card.Value);
            }
            Console.WriteLine(drawPile.Count + output.Count);
            Console.WriteLine(drawPile.Intersect(output).ToList().Count);

            return output.OrderBy(keySelector: c => (c.Suit, c.Value)).ToList();
        }
    }
}
