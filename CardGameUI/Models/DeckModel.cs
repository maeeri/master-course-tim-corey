using System;
using System.Collections.Generic;
using System.Linq;
using CardGameUI.Enums;
using CardGameUI.Models;

namespace CardGameUI.Models
{
    public abstract class DeckModel
    {
        protected List<PlayingCardModel> fullDeck { get; set; } = new List<PlayingCardModel>();
        protected List<PlayingCardModel> drawPile { get; set; } = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile { get; set; } = new List<PlayingCardModel>();

        public virtual void ShuffleDeck()
        {
            var rand = new Random();
            drawPile = fullDeck.OrderBy(c => rand.Next()).ToList();
        }

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
        public abstract List<PlayingCardModel> DealCards();
        protected void CreateDeck()
        {
            fullDeck.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuitEnum)i, Value = (CardValueEnum)j });
                }
            }
        }
    }
}
