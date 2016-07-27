using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Games
{
    class DeckOfCards : Card
    {
        const int MaxCards = 52; //maximum van kaarten
        private Card[] deck; //dit is de verzameling van alle kaarten

        public DeckOfCards() //de constuctor 
        {
            deck = new Card[MaxCards];
        }

        public Card[] getDeck { get { return deck; } } //voor in de andere klasse te plaatsen

        public void setDeck()
        {
            int i = 0;
            foreach (Suits s in Enum.GetValues(typeof(Suits)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                    deck[i] = new Card { mySuit = s, myValue = v };
                    i++;
                }
            }
            shuffle();
        }

        //kaarten schudden
        public void shuffle()
        {
            Random rand = new Random();
            Card temp;

            // 100 keer schudden
            for (int shuffle100 = 0; shuffle100 < 100; shuffle100++)
            {
                for (int i = 0; i < MaxCards; i++)
                {
                    int secondCardIndex = rand.Next(13); //Want er zijn 13 kaarten voor elke suit
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}
