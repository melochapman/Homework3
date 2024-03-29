using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King

    }
    public enum Suit
    {Club,Spades,Diamonds, Hearts }
    public class DeckBuilder
    {
        List<string> cardNames { get; set; }

        Dictionary<string,int> deck {  get; set; }

        public int cardValue { get; set; }

        public static List<string> CardNames()
        {
            List<string> cardNames = new List<string>();


            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face f in Enum.GetValues(typeof(Face)))
                {
                    string cards = $"{f} of {s}";
                    cardNames.Add(cards);
                }
            }
            return cardNames;
        }

        public static Dictionary<string, int> Generate()
        {
            CardNames();
            Dictionary<string, int> deck = new Dictionary<string, int>();
            foreach (string card in CardNames())
            {
                string face = card.Split(' ')[0]; //the will save the first string before the first space

                switch (face)
                {
                    case "Ace":
                        deck.Add(card, 1);
                        break;
                    case "Two":
                        deck.Add(card, 2); break;
                    case "Three":
                        deck.Add(card, 3); break;
                    case "Four":
                        deck.Add(card, 4); break;
                    case "Five":
                        deck.Add(card, 5); break;
                    case "Six":
                        deck.Add(card, 6); break;
                    case "Seven":
                        deck.Add(card, 7); break;
                    case "Eight":
                        deck.Add(card, 8); break;
                    case "Nine":
                        deck.Add(card, 9); break;
                    case "Ten":
                        deck.Add(card, 10); break;
                    case "Jack":
                        deck.Add(card, 11); break;
                    case "Queen":
                        deck.Add(card, 12); break;
                    case "King":
                        deck.Add(card, 13); break;
                    default:
                        break;
                }
            }
            return deck;
        }
    }

    
}
