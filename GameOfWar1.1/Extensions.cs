using System.Collections.Generic;

namespace GameOfWar1._1
{
    /**
     * 
     * This class contains a method that places our playing cards into our queue 
     */
    public static class Extensions
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }
    }
}