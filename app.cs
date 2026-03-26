using System;

namespace MyProject
{
    public enum Rank
    {
        ACE = 1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING
    }
    public enum Suit
    {
        HEARTS,
        CLUBS,
        DIAMONDS,
        SPADES
    }
    public class Card
    {
        private Rank rank;
        private int value;
        private Suit suit;
        private bool isFaceDown;

        public int Value {
            get{ 
                switch(rank) {
                    case Rank.TWO:
                        value = 2;
                        break;
                    case Rank.THREE:
                        value = 3;
                        break;
                    case Rank.FOUR:
                        value = 4;
                        break;
                    case Rank.FIVE:
                        value = 5;
                        break;
                    case Rank.SIX:
                        value = 6;
                        break;
                    case Rank.SEVEN:
                        value = 7;
                        break;
                    case Rank.EIGHT:
                        value = 8;
                        break;
                    case Rank.NINE:
                        value = 9;
                        break;
                    case Rank.TEN:
                        value = 10;
                        break;
                    case Rank.JACK:
                        value = 11;
                        break;
                    case Rank.QUEEN:
                        value = 11;
                        break;
                    case Rank.KING:
                        value = 11;
                        break;
                }
                return value;
            }
        }

        public Card(Rank rank, Suit suit) {
            this.rank = rank;
            this.suit = suit;
        }

        public void Flip()
        {

        }

        public void Shuffle() {
            Random rnd = new Random();
        }

        public override string ToString() {
            return rank.ToString() + " OF " + suit.ToString();
        }
    }
}