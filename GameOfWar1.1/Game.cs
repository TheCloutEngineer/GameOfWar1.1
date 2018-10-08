using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfWar1._1
{
         public class Game
    {
        private Player Player1;
        private Player Player2;
        public int TurnCount;
        
        public Game(string player1name, string player2name)
        {
            Player1 = new Player(player1name);
            Player2 = new Player(player2name);

            var cards = DeckGenerator.CreateCards(); //Returns a shuffled set of cards

            var deck = Player1.Deal(cards); //Returns Player2's deck.  Player1 keeps his.
            Player2.Deck = deck;
        }
        
        public void PlayTurn()
        {
            Queue<Card> pool = new Queue<Card>();

            var player1card = Player1.Deck.Dequeue();
            var player2card = Player2.Deck.Dequeue();

            pool.Enqueue(player1card);
            pool.Enqueue(player2card);

            Console.WriteLine(Player1.Name + " plays " + player1card+ ", " + Player2.Name + " plays " + player2card);

            while (player1card.value == player2card.value)
            {
                Console.WriteLine("WAR!");
                if (Player1.Deck.Count < 4)
                {
                    Player1.Deck.Clear();
                    return;
                }
                if(Player2.Deck.Count < 4)
                {
                    Player2.Deck.Clear();
                    return;
                }
                
                pool.Enqueue(Player1.Deck.Dequeue());
                pool.Enqueue(Player1.Deck.Dequeue());
                pool.Enqueue(Player1.Deck.Dequeue());
                pool.Enqueue(Player2.Deck.Dequeue());
                pool.Enqueue(Player2.Deck.Dequeue());
                pool.Enqueue(Player2.Deck.Dequeue());

                player1card = Player1.Deck.Dequeue();
                player2card = Player2.Deck.Dequeue();

                pool.Enqueue(player1card);
                pool.Enqueue(player2card);

                Console.WriteLine(Player1.Name + " plays " + player1card + ", " + Player2.Name + " plays " + player2card);
            }

            if(player1card.value < player2card.value)
            {
                Player2.Deck.Enqueue(pool);
                Console.WriteLine(Player2.Name + " Wins this hand!");
            }
            else
            {
                Player1.Deck.Enqueue(pool);
                Console.WriteLine(Player1.Name + " Wins this hand!");
            }

            TurnCount++;
        }

        public bool IsGameOver()
        {
            string win = " Has won the match!!!!";
            string cards = " is out of cards ";
            
            if (!Player1.Deck.Any())
            {
                Console.WriteLine(Player1.Name + cards + Player2.Name + win);
                return true;
            } else if (!Player2.Deck.Any())
            {
                Console.WriteLine(Player2.Name + cards + Player1.Name + win);
                return true;
            } 
              else if (TurnCount > 1000)
            {
                Console.WriteLine("Error!! INFINITE GAME MATCH OVER!!!");
                return true;
            }
            return false;
        }
    }
}