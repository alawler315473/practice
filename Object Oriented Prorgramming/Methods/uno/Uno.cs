using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno1
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a game similar to Uno: use the below as guidance

            //removed wilds to change to suit of card to make code simpler feel free to change to suport full wild behaivior.
            //Ace is Draw 4 Card can be played at any time and will switch suit to the suit of the Ace
            //king is Wild card that can be played at any time and will switch suit to the suit of the King
            //Queen is Draw 2 Card Next player draws 2 cards
            //Jack is skip Card

            ///////// The below is just for guidance - you do not need to do it the way outlined below/////////////

            //create a list of players
            List<Player> playersInGame = new List<Player>();

            //ask the user to enter a number of players 2-5
            Console.WriteLine(" Enter the number of players, 2-5: ");
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            //create as many players as indicated by user and add each to  the list of players
            for (int i = 0; i < numOfPlayers; i++)
            {
                Player player1 = new Player();
                playersInGame.Add(player1);
            }

            //create an object called gameDeck that is an instance of the deck class
            Deck gameDeck = new Deck();

            //shuffle the game deck
            gameDeck.ShuffleAll();

            //deal 7 cards to each player\
            Card drawCard = gameDeck.DrawCard();
            for (int i = 0; i < numOfPlayers; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    playersInGame[i].AddCardToHand(drawCard);
                }
            }

            //draw the first card
            Card firstCard = gameDeck.DrawCard();

            //place card on the discard pile
            gameDeck.DiscardCard(gameDeck.DrawCard());

            //While the game is not over (players still have cards)
            int currentPlayer = 0;
            while (true)
            {
                // check if previous card was special card(see above) and do what it tell you to do
                if(gameDeck.ReadDiscardPile().GetDisplayValue() == "J")
                {
                    currentPlayer = (currentPlayer + 1) % numOfPlayers; //go to next player
                } 
                else if (gameDeck.ReadDiscardPile().GetDisplayValue() == "Q")
                {
                    for(int i = 0; i < 2; i++)
                    {
                        playersInGame[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    }
                    
                }
                else if (gameDeck.ReadDiscardPile().GetDisplayValue() == "A")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        playersInGame[currentPlayer].AddCardToHand(gameDeck.DrawCard());
                    }
                }

                    // check currentPlayer's available moves
                    // if no moves are available draw a card until a move is available
                    while (!playersInGame[currentPlayer].PrintValidMoves(gameDeck.ReadDiscardPile()))
                {
                    Card drawnCard = gameDeck.DrawCard();
                    playersInGame[currentPlayer].AddCardToHand(drawCard);
                }
                
                // if valid move found prompt user to enter cardName
                // play the card the user selected and discard the card.
                // move to next player in the list
                if (playersInGame[currentPlayer].PrintValidMoves(gameDeck.ReadDiscardPile()))
                {
                    Console.WriteLine("Enter CardName: ");
                    string cardName = Console.ReadLine();
                    gameDeck.DiscardCard(playersInGame[currentPlayer].GetCardByName(cardName));
                 
                }
                currentPlayer = (currentPlayer + 1) % numOfPlayers; //go to next player
            }
        }
    }
}

