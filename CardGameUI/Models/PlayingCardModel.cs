using CardGameUI.Enums;

namespace CardGameUI.Models
{
    public class PlayingCardModel
    {
        public CardSuitEnum Suit { get; set; }  
        public CardValueEnum Value { get; set; }
        public bool FaceUp { get; set; } = false;
    }
}
