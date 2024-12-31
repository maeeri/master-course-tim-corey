using System;
using System.Collections.Generic;
using CardGameUI.Models;

namespace CardGameUI.Models
{
    public class BlackJackDeckModel : DeckModel
    {
        public BlackJackDeckModel()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            var output = new List<PlayingCardModel>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }

        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }
}
