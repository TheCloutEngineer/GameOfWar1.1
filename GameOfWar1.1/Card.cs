namespace GameOfWar1._1
{
        public enum Suit
        {
            Diamonds, Spades, Clubs, Hearts
        }
        public enum FaceValue
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }
    
        public class Card
    
        {   
            // Members/Fields
            public Suit suit;
            private readonly FaceValue faceVal;
        
            // Properties
            public Suit Suit { get { return suit; } }
            public FaceValue FaceVal { get { return faceVal; } }

            public int value { get; set; }

            // Constructor
            public Card(Suit suit, int faceVal)
            {
                this.suit = suit;
                this.faceVal = (FaceValue) faceVal;
            }
            // Override
            public override string ToString()
            {
                return "The " + faceVal.ToString() + " of " + suit.ToString();
            }
        }
    }
