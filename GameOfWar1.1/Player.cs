using System.Collections.Generic;
using System.Linq;

namespace GameOfWar1._1
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }
        
        public Player(string name)
        {
            Name = name;
        }
        /** Will have two properties 
         * 1. name
         * 2. A Collection of Cards
         *     Queue  FIFO
         *     Deal method Deal cards to Player1 and Player2.
         */

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1Cards = new Queue<Card>();
            Queue<Card> player2Cards = new Queue<Card>();

            int counter = 2;

            while (cards.Any())
            {
                if (counter % 2 == 0)
                {
                    player2Cards.Enqueue(cards.Dequeue());
                }
                else
                {
                    player1Cards.Enqueue(cards.Dequeue());
                }

                counter++;

            }

            Deck = player1Cards;
            return player2Cards;
        }
    }
  }