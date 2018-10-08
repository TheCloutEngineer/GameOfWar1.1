using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfWar1._1
{
    public static class DeckGenerator
    {
        public static Queue<Card> CreateCards()
            /**
             * Start at 2 because Aces are counted higher than King
             * giving them a value of '14'.
             */
        {
            Queue<Card> cards = new Queue<Card>();
            for (int i = 2; i <=  14 ; i++)
            {
                
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card(suit,i)
                    {
                        suit = suit,
                        value = i
                    });
                }
            }

            return Shuffle(cards);
        }

        private static Queue<Card> Shuffle(Queue<Card> cards)
        {
            //Shuffle the existing cards using Fisher-Yates Modern
            List<Card> transformedCards = cards.ToList();
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = transformedCards.Count - 1; i >= 0; --i)
            {
                //Randomly  pick a card which has not been shuffled
                int j = random.Next(i + 1);
                
                //Swap the selected item with the last "unselected" card in the Collection
                Card temp = transformedCards[i];
                transformedCards[i] = transformedCards[j];
                transformedCards[j] = temp;
            }
            Queue<Card> shuffleCards = new Queue<Card>();
            foreach (var card in transformedCards)
            {
                shuffleCards.Enqueue(card);
            }

            return shuffleCards;
        }
        }
    }