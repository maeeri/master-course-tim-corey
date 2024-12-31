using System;
using System.Collections.Generic;
using CardGameUI.Models;

namespace CardGameUI.Models
{
    public class PokerDeckModel : DeckModel
    {
        public PokerDeckModel()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            var output = new List<PlayingCardModel>();
            for (int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            var output = new List<PlayingCardModel>();
            foreach (var card in cardsToDiscard)
            {
                discardPile.Add(card);
                output.Add(DrawOneCard());
            }
            return output;
        }
    }
}
