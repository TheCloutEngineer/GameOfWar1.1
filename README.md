# Objective
    Provide a set of code on how you would design a
    detail version of the classic card game of war
# The OutCome
 * Inputs:  This program does not ask use for any input.
 * Output: The winner of War card game.
# War
    
* Each player gets half a shuffled deck of cards
* Aces are higher than Kings
* Players flip one card at a time, highest card wins
* If flipped cards are same value, a War is declared
* War is played until a player wins all cards on table
* The first player to run out of cards loses.  
    
## Objects needed for the game
* Card
* Deck
* Player 
* Game (Also known as Program.cs)
 
![A playing card](A-spade.png?raw=true)
    
    FaceName: Ace of Spade
    FaceValue: =14
    Suit: ♠
    CardImg: Unicode ♠
   
# Card
    Created a int of value and suit
    if or switch to append Value to rank
    
# Player
    I created a string call name 
    and and a queue of Decks.
# Game
        To model the game we create two players
        and a deck of cards.
# Deck
    To get a representation of playing
    cards. I created a queue to hold a multiple 
    decks of cards and created a Enqueue method
    to place multiple cards in each stop in the queue.
    
    When it came to shuffling the cards
    I found out C# doesn't have a Shuffle method.
    Unlike C#. So I use the Fisher-Yates Methods.
     