using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject Card11;
    public GameObject Card12;
    public GameObject Card13;
    public GameObject Card14;
    public GameObject Card15;
    public GameObject Card16;
    public GameObject Card17;
    public GameObject Card18;
    public GameObject Card19;
    public GameObject Card20;
    public GameObject Card21;
    public GameObject Card22;
    public GameObject Card23;
    public GameObject Card24;
    public GameObject Card25;
    public GameObject Card26;
    public GameObject Card27;
    public GameObject Card28;
    public GameObject Card29;
    public GameObject Card30;
    public GameObject Card31;
    public GameObject Card32;
    public GameObject Card33;
    public GameObject Card34;
    public GameObject Card35;
    public GameObject Card36;
    public GameObject Card37;
    public GameObject Card38;
    public GameObject Card39;
    public GameObject Card40;
    public GameObject Card41;
    public GameObject Card42;
    public GameObject Card43;
    public GameObject Card44;
    public GameObject Card45;
    public GameObject Card46;
    public GameObject Card47;
    public GameObject Card48;
    public GameObject Card49;
    public GameObject Card50;
    public GameObject Card51;
    public GameObject Card52;
    public GameObject Card53;
    public GameObject Card54;
    public GameObject Card55;
    public GameObject Card56;
    public GameObject Card57;
    public GameObject Card58;
    public GameObject Card59;
    public GameObject Card60;
    public GameObject Card61;
    public GameObject Card62;
    public GameObject Card63;
    public GameObject Card64;
    public GameObject Card65;
    public GameObject Card66;
    public GameObject Card67;
    public GameObject Card68;
    public GameObject Card69;
    public GameObject Card70;
    public GameObject Card71;
    public GameObject Card72;
    public GameObject Card73;
    public GameObject Card74;
    public GameObject Card75;
    public GameObject Card76;
    public GameObject Card77;
    public GameObject Card78;
    public GameObject Card79;
    public GameObject Card80;
    public GameObject Card81;
    public GameObject Card82;
    public GameObject Card83;
    public GameObject Card84;
    public GameObject Card85;
    public GameObject Card86;
    public GameObject Card87;
    public GameObject Card88;
    public GameObject Card89;
    public GameObject Card90;
    public GameObject Card91;
    public GameObject Card92;
    public GameObject Card93;
    public GameObject Card94;
    public GameObject Card95;
    public GameObject Card96;
    public GameObject Card97;
    public GameObject Card98;
    public GameObject Card99;
    public GameObject Card100;
    public GameObject Card101;
    public GameObject Card102;
    public GameObject Card103;
    public GameObject Card104;
    public GameObject Card105;
    public GameObject Card106;
    public GameObject Card107;
    public GameObject Card108;

    //public GameObject Card109;
    //public GameObject Card110;
    //public GameObject Card111;
    //public GameObject Card112;







    //Useful game Objects
    public GameObject DrawnPile;
    public GameObject PlayerArea;
    public GameObject HumboldtStateUno;
    public GameObject rules;
    public GameObject DeckCard;
    public GameObject StartButton;
    public GameObject AiCard1;
    public GameObject AiCard2;
    public GameObject AiCard3;

    //int the cardValue list the 1 values are card num 37-40
    List<GameObject> deck = new List<GameObject>();
    void Awake()
    {
        

        //adding all the Gameobject Cards to a vector (list).
        deck.Add(Card1 );

        /*
        deck.Add(Card2);
        deck.Add(Card3);
        deck.Add(Card4);
        deck.Add(Card5);
        deck.Add(Card6);
        deck.Add(Card7);
        deck.Add(Card8);
        deck.Add(Card9);
        deck.Add(Card10);
        deck.Add(Card11);
        deck.Add(Card12);
        deck.Add(Card13);
        deck.Add(Card14);
        deck.Add(Card15);
        deck.Add(Card16);
        deck.Add(Card17);
        deck.Add(Card18);
        deck.Add(Card19);
        deck.Add(Card20);
        deck.Add(Card21);
        deck.Add(Card22);
        deck.Add(Card23);
        deck.Add(Card24);
        deck.Add(Card25);
        deck.Add(Card26);
        deck.Add(Card27);
        deck.Add(Card28);
        deck.Add(Card29);
        deck.Add(Card30);
        deck.Add(Card31);
        deck.Add(Card32);
        deck.Add(Card33);
        deck.Add(Card34);
        deck.Add(Card35);
        deck.Add(Card36);
        deck.Add(Card37);
        deck.Add(Card38);
        deck.Add(Card39);
        deck.Add(Card40);
        deck.Add(Card41);
        deck.Add(Card42);
        deck.Add(Card43);
        deck.Add(Card44);
        deck.Add(Card45);
        deck.Add(Card46);
        deck.Add(Card47);
        deck.Add(Card48);
        deck.Add(Card49);
        deck.Add(Card50);
        deck.Add(Card51);
        deck.Add(Card53);
        deck.Add(Card54);
        deck.Add(Card55);
        deck.Add(Card56);
        deck.Add(Card56);
        deck.Add(Card57);
        deck.Add(Card58);
        deck.Add(Card59);
        deck.Add(Card60);
        deck.Add(Card61);
        deck.Add(Card62);
        deck.Add(Card63);
        deck.Add(Card64);
        deck.Add(Card65);
        deck.Add(Card66);
        deck.Add(Card67);
        deck.Add(Card68);
        deck.Add(Card69);
        deck.Add(Card70);
        deck.Add(Card71);
        deck.Add(Card72);
        deck.Add(Card73);
        deck.Add(Card74);
        deck.Add(Card75);
        deck.Add(Card76);
        deck.Add(Card77);
        deck.Add(Card78);
        deck.Add(Card79);
        deck.Add(Card80);
        deck.Add(Card81);
        deck.Add(Card82);
        deck.Add(Card83);
        deck.Add(Card84);
        deck.Add(Card85);
        deck.Add(Card86);
        deck.Add(Card87);
        deck.Add(Card88);
        deck.Add(Card89);
        deck.Add(Card90);
        deck.Add(Card91);
        deck.Add(Card92);
        deck.Add(Card93);
        deck.Add(Card94);
        deck.Add(Card95);
        deck.Add(Card96);
        deck.Add(Card97);
        deck.Add(Card98);
        deck.Add(Card99);
        deck.Add(Card100);
        deck.Add(Card101);
        deck.Add(Card102);
        deck.Add(Card103);
        deck.Add(Card104);
        deck.Add(Card105);
        deck.Add(Card106);
        deck.Add(Card107);
        deck.Add(Card108);

        */

        //These will be used for the extra wildcard mode
        //deck.Add(Card109);
        //deck.Add(Card110);
        //deck.Add(Card111);
        //deck.Add(Card112);

    }

    public void OnClick()
    {

        //after start button is clicked
       // Get rid of the starting screens text
        HumboldtStateUno.active = false;
        rules.active = false;
        DeckCard.active = true;
        StartButton.active = false;
        PlayerArea.active = true;

        //Turning on the placeholder cards for the AI
        AiCard1.active = true;
        AiCard2.active = true;
        AiCard3.active = true;


        for (int i =0; i < 4; i ++)
        {
            GameObject PlayerCard = Instantiate(deck[Random.Range(deck.Count - 1, deck.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
            PlayerCard.transform.SetParent(PlayerArea.transform, false);

        }

        GameObject DrawPile = Instantiate(deck[Random.Range(deck.Count - 1, deck.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
        DrawPile.transform.SetParent(DrawnPile.transform, false);

        //Active certain starting function of the game. (Show deck, and cards being passed out to players).
        //Have something like this
        /*
       While(!winner) 
       {

           //Each player and AI will have a "deck" which is a hand
           foreach(deck player in game)
           {
               if(!AIturn)
               {
                   do players turn 
               }
               else()
               {
                   //looping through the players (or AI's) hand.
                   for(int i=0; i < deck; i++) 
                   {

                   AI will play this way 
                   if(deck.color == playedDeck.color)
                   {
                       //Sometype of playcard function for AI
                       break;
                   }
                   if(deck.num == playedDeck.num)
                   {
                       //Sometype of playcard function for AI
                       break;
                   }
                   //Somehow also setup a way of determing if an AI has a wildcard (more than likly compare against templet card)
                   else()
                   {
                       DrawCard();
                   }


                   }
               }

           }
       }

       //When while loop is broken
       //Either you won text is set to true or you lost text is set to false.




       */
    }

    public GameObject DrawCard ()
    {
        /* 
         * access the deck and create a temp card before "deleting" the top card of the deck
         * 
         * GameObject tempCard = deck.Last();
         * deck.RemoveAt(deck.Count - 1);
         * 
         * 
         * 
         * 
         */
        return Card1;
    }

    public List<GameObject> Shuffle(List<GameObject> deck)
    {
        /* 
        
        
        
        */

        return deck;
    }


    /*
     * for the actually game a card being played needs to be compared to the current card on the "Played" card deck. 
     * if (Card.color 
     * 
     * 
     * 
     * 
     * 
     *
     */




    /*public int GamePacer (int playerScore)
    {

            for (var i = 0; i < 2; i++)
            {
                // the value needed to draw a random card

                TempValues = cards[Random.Range(0, cards.Count)];


                //Getting the index of TempValues in the cards GameObject list
                index = cards.IndexOf(TempValues);

                // TempPlayerTotal is number at which the index is - Card.count before the TempValues is moved to the back of the deck.
                tempPlayerTotal = 0;
                tempPlayerTotal = index;
                playerTotal = cardValue[tempPlayerTotal];
                playerTotal = GetPlayerTotal(playerTotal);
                PlayerTotal.scoreValue = playerTotal;

                //Adding TempValues to the back of the deck.
                cards.Add(TempValues);

                // Putting the Cards on the table
                GameObject playerCard = Instantiate(cards[Random.Range(cards.Count - 1, cards.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

                //Removing cards from the back of the deck
                cards.RemoveAt(cards.Count - 1);
                cards.RemoveAt(cards.Count - 2);


                //Dealer 
                TempValues = cards[Random.Range(0, cards.Count)];
                tempDealerTotal = 0;
                tempDealerTotal = index;
                dealerTotal = cardValue[tempDealerTotal];
                dealerTotal = GetDealerTotal(dealerTotal);

                cards.Add(TempValues);
                GameObject enemyCard = Instantiate(cards[Random.Range(cards.Count - 1, cards.Count - 1)], new Vector3(0, 0, 0), Quaternion.identity);
                enemyCard.transform.SetParent(EnemyArea.transform, false);

                cards.RemoveAt(cards.Count - 1);
                cards.RemoveAt(cards.Count - 2);
                
            }
        return playerTotal;
        
    }
    */
}

