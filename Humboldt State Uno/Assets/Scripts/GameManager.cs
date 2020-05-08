using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO.IsolatedStorage;
using System.Net;

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
    public GameObject DeckCard;
    public GameObject StartButton;
    public GameObject AiCard1;
    public GameObject AiCard2;
    public GameObject AiCard3;
    public GameObject PlayerCard;

    //List that are used in the game
    public List<Card> playerDeck = new List<Card>();
    public List<Card> drawnPile = new List<Card>();
    public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> cardClones = new List<GameObject>();
    public List<GameObject> playerObjectHand = new List<GameObject>();
    public List<GameObject> drawnObjectPile = new List<GameObject>();


    //Everyone in the game has a hand (hopefully two)
    List<List<Card>> gamerTracker = new List<List<Card>>();
    List<Card> playerHand = new List<Card>();
    List<Card> AI1Hand = new List<Card>();
    List<Card> AI2Hand = new List<Card>();
    List<Card> AI3Hand = new List<Card>();

    //text for amount of cards in hand
    public Text AI1CardCount;
    public Text AI2CardCount;
    public Text AI3CardCount;
    public Text winText;


    public class Card
    {
        public int number { get; set; }
        public string color { get; set; }
        public bool wild { get; set; }
        public bool haveAbility { get; set; }
        public string ability { get; set; }
        public int IDtag { get; set;  }
    }

    void Awake()
    {
        //This is the following format for the card building process
        //Declare a new card of type CARD (See above card class)
        //each card has a number attachted to it for comparison. If two cards have the same number they can be played on top of each other. 10 = draw two, 11 = reverse, 12 = skip, 13 = wild, 14 = wild draw four  
        //If as card is a wild it can be played at any time. Its a boolean for the compasion against the current card on the played pile
        //Have ability is a boolean if I need to after it's played
        //if Haveability = true there will be ability string attached to the card
        //The cards all have a IDtag on them to interact with the gameobject prefabs. IDtags start at zero because of position in a list
        //Lastly each card is added to a playerDeck. (player deck is the main starting deck)

        Card playerCard1 = new Card();
        playerCard1.color = "red";
        playerCard1.number = 0;
        playerCard1.wild = false;
        playerCard1.haveAbility = false;
        playerCard1.IDtag = 0;
        playerDeck.Add(playerCard1);

        Card playerCard2 = new Card();
        playerCard2.color = "red";
        playerCard2.number = 1;
        playerCard2.wild = false;
        playerCard2.haveAbility = false;
        playerCard2.IDtag = 1;
        playerDeck.Add(playerCard2);

        Card playerCard3 = new Card();
        playerCard3.color = "red";
        playerCard3.number = 1;
        playerCard3.wild = false;
        playerCard3.haveAbility = false;
        playerCard3.IDtag = 2;
        playerDeck.Add(playerCard3);

        Card playerCard4 = new Card();
        playerCard4.color = "red";
        playerCard4.number = 2;
        playerCard4.wild = false;
        playerCard4.haveAbility = false;
        playerCard4.IDtag = 3;
        playerDeck.Add(playerCard4);


        Card playerCard5 = new Card();
        playerCard5.color = "red";
        playerCard5.number = 2;
        playerCard5.wild = false;
        playerCard5.haveAbility = false;
        playerCard5.IDtag = 4;
        playerDeck.Add(playerCard5);

        Card playerCard6 = new Card();
        playerCard6.color = "red";
        playerCard6.number = 3;
        playerCard6.wild = false;
        playerCard6.haveAbility = false;
        playerCard6.IDtag = 5;
        playerDeck.Add(playerCard6);

        Card playerCard7 = new Card();
        playerCard7.color = "red";
        playerCard7.number = 3;
        playerCard7.wild = false;
        playerCard7.haveAbility = false;
        playerCard7.IDtag = 6;
        playerDeck.Add(playerCard7);

        Card playerCard8 = new Card();
        playerCard8.color = "red";
        playerCard8.number = 4;
        playerCard8.wild = false;
        playerCard8.haveAbility = false;
        playerCard8.IDtag = 7;
        playerDeck.Add(playerCard8);

        Card playerCard9 = new Card();
        playerCard9.color = "red";
        playerCard9.number = 4;
        playerCard9.wild = false;
        playerCard9.haveAbility = false;
        playerCard9.IDtag = 8;
        playerDeck.Add(playerCard9);

        Card playerCard10 = new Card();
        playerCard10.color = "red";
        playerCard10.number = 5;
        playerCard10.wild = false;
        playerCard10.haveAbility = false;
        playerCard10.IDtag = 9;
        playerDeck.Add(playerCard10);

        Card playerCard11 = new Card();
        playerCard11.color = "red";
        playerCard11.number = 5;
        playerCard11.wild = false;
        playerCard11.haveAbility = false;
        playerCard11.IDtag = 10;
        playerDeck.Add(playerCard11);

        Card playerCard12 = new Card();
        playerCard12.color = "red";
        playerCard12.number = 6;
        playerCard12.wild = false;
        playerCard12.haveAbility = false;
        playerCard12.IDtag = 11;
        playerDeck.Add(playerCard12);

        Card playerCard13 = new Card();
        playerCard13.color = "red";
        playerCard13.number = 6;
        playerCard13.wild = false;
        playerCard13.haveAbility = false;
        playerCard13.IDtag = 12;
        playerDeck.Add(playerCard13);

        Card playerCard14 = new Card();
        playerCard14.color = "red";
        playerCard14.number = 7;
        playerCard14.wild = false;
        playerCard14.haveAbility = false;
        playerCard14.IDtag = 13;
        playerDeck.Add(playerCard14);

        Card playerCard15 = new Card();
        playerCard15.color = "red";
        playerCard15.number = 7;
        playerCard15.wild = false;
        playerCard15.haveAbility = false;
        playerCard15.IDtag = 14;
        playerDeck.Add(playerCard15);

        Card playerCard16 = new Card();
        playerCard16.color = "red";
        playerCard16.number = 8;
        playerCard16.wild = false;
        playerCard16.haveAbility = false;
        playerCard16.IDtag = 15;
        playerDeck.Add(playerCard16);

        Card playerCard17 = new Card();
        playerCard17.color = "red";
        playerCard17.number = 8;
        playerCard17.wild = false;
        playerCard17.haveAbility = false;
        playerCard17.IDtag = 16;
        playerDeck.Add(playerCard17);

        Card playerCard18 = new Card();
        playerCard18.color = "red";
        playerCard18.number = 9;
        playerCard18.wild = false;
        playerCard18.haveAbility = false;
        playerCard18.IDtag = 17;
        playerDeck.Add(playerCard18);

        Card playerCard19 = new Card();
        playerCard19.color = "red";
        playerCard19.number = 9;
        playerCard19.wild = false;
        playerCard19.haveAbility = false;
        playerCard19.IDtag = 18;
        playerDeck.Add(playerCard19);

        Card playerCard20 = new Card();
        playerCard20.color = "yellow";
        playerCard20.number = 0;
        playerCard20.wild = false;
        playerCard20.haveAbility = false;
        playerCard20.IDtag = 19;
        playerDeck.Add(playerCard20);

        Card playerCard21 = new Card();
        playerCard21.color = "yellow";
        playerCard21.number = 1;
        playerCard21.wild = false;
        playerCard21.haveAbility = false;
        playerCard21.IDtag = 20;
        playerDeck.Add(playerCard21);

        Card playerCard22 = new Card();
        playerCard22.color = "yellow";
        playerCard22.number = 1;
        playerCard22.wild = false;
        playerCard22.haveAbility = false;
        playerCard22.IDtag = 21;
        playerDeck.Add(playerCard22);

        Card playerCard23 = new Card();
        playerCard23.color = "yellow";
        playerCard23.number = 2;
        playerCard23.wild = false;
        playerCard23.haveAbility = false;
        playerCard23.IDtag = 22;
        playerDeck.Add(playerCard23);

        Card playerCard24 = new Card();
        playerCard24.color = "yellow";
        playerCard24.number = 2;
        playerCard24.wild = false;
        playerCard24.haveAbility = false;
        playerCard24.IDtag = 23;
        playerDeck.Add(playerCard24);

        Card playerCard25 = new Card();
        playerCard25.color = "yellow";
        playerCard25.number = 3;
        playerCard25.wild = false;
        playerCard25.haveAbility = false;
        playerCard25.IDtag = 24;
        playerDeck.Add(playerCard25);

        Card playerCard26 = new Card();
        playerCard26.color = "yellow";
        playerCard26.number = 3;
        playerCard26.wild = false;
        playerCard26.haveAbility = false;
        playerCard26.IDtag = 25;
        playerDeck.Add(playerCard26);

        Card playerCard27 = new Card();
        playerCard27.color = "yellow";
        playerCard27.number = 4;
        playerCard27.wild = false;
        playerCard27.haveAbility = false;
        playerCard27.IDtag = 26;
        playerDeck.Add(playerCard27);

        Card playerCard28 = new Card();
        playerCard28.color = "yellow";
        playerCard28.number = 4;
        playerCard28.wild = false;
        playerCard28.haveAbility = false;
        playerCard28.IDtag = 27;
        playerDeck.Add(playerCard28);

        Card playerCard29 = new Card();
        playerCard29.color = "yellow";
        playerCard29.number = 5;
        playerCard29.wild = false;
        playerCard29.haveAbility = false;
        playerCard29.IDtag = 28;
        playerDeck.Add(playerCard29);

        Card playerCard30 = new Card();
        playerCard30.color = "yellow";
        playerCard30.number = 5;
        playerCard30.wild = false;
        playerCard30.haveAbility = false;
        playerCard30.IDtag = 29;
        playerDeck.Add(playerCard30);

        Card playerCard31 = new Card();
        playerCard31.color = "yellow";
        playerCard31.number = 6;
        playerCard31.wild = false;
        playerCard31.haveAbility = false;
        playerCard31.IDtag = 30;
        playerDeck.Add(playerCard31);

        Card playerCard32 = new Card();
        playerCard32.color = "yellow";
        playerCard32.number = 6;
        playerCard32.wild = false;
        playerCard32.haveAbility = false;
        playerCard32.IDtag = 31;
        playerDeck.Add(playerCard32);

        Card playerCard33 = new Card(); ;
        playerCard33.color = "yellow";
        playerCard33.number = 7;
        playerCard33.wild = false;
        playerCard33.haveAbility = false;
        playerCard33.IDtag = 32;
        playerDeck.Add(playerCard33);

        Card playerCard34 = new Card();
        playerCard34.color = "yellow";
        playerCard34.number = 7;
        playerCard34.wild = false;
        playerCard34.haveAbility = false;
        playerCard34.IDtag = 33;
        playerDeck.Add(playerCard34);

        Card playerCard35 = new Card();
        playerCard35.color = "yellow";
        playerCard35.number = 8;
        playerCard35.wild = false;
        playerCard35.haveAbility = false;
        playerCard35.IDtag = 34;
        playerDeck.Add(playerCard35);

        Card playerCard36 = new Card();
        playerCard36.color = "yellow";
        playerCard36.number = 8;
        playerCard36.wild = false;
        playerCard36.haveAbility = false;
        playerCard36.IDtag = 35;
        playerDeck.Add(playerCard36);

        Card playerCard37 = new Card();
        playerCard37.color = "yellow";
        playerCard37.number = 9;
        playerCard37.wild = false;
        playerCard37.haveAbility = false;
        playerCard37.IDtag = 36;
        playerDeck.Add(playerCard37);

        Card playerCard38 = new Card();
        playerCard38.color = "yellow";
        playerCard38.number = 9;
        playerCard38.wild = false;
        playerCard38.haveAbility = false;
        playerCard38.IDtag = 37;
        playerDeck.Add(playerCard38);

        Card playerCard39 = new Card();
        playerCard39.color = "blue";
        playerCard39.number = 0;
        playerCard39.wild = false;
        playerCard39.haveAbility = false;
        playerCard39.IDtag = 38;
        playerDeck.Add(playerCard39);

        Card playerCard40 = new Card();
        playerCard40.color = "blue";
        playerCard40.number = 1;
        playerCard40.wild = false;
        playerCard40.haveAbility = false;
        playerCard40.IDtag = 39;
        playerDeck.Add(playerCard40);

        Card playerCard41 = new Card();
        playerCard41.color = "blue";
        playerCard41.number = 1;
        playerCard41.wild = false;
        playerCard41.haveAbility = false;
        playerCard41.IDtag = 40;
        playerDeck.Add(playerCard41);

        Card playerCard42 = new Card();
        playerCard42.color = "blue";
        playerCard42.number = 2;
        playerCard42.wild = false;
        playerCard42.haveAbility = false;
        playerCard42.IDtag = 41;
        playerDeck.Add(playerCard42);

        Card playerCard43 = new Card();
        playerCard43.color = "blue";
        playerCard43.number = 2;
        playerCard43.wild = false;
        playerCard43.haveAbility = false;
        playerCard43.IDtag = 42;
        playerDeck.Add(playerCard43);

        Card playerCard44 = new Card();
        playerCard44.color = "blue";
        playerCard44.number = 3;
        playerCard44.wild = false;
        playerCard44.haveAbility = false;
        playerCard44.IDtag = 43;
        playerDeck.Add(playerCard44);

        Card playerCard45 = new Card();
        playerCard45.color = "blue";
        playerCard45.number = 3;
        playerCard45.wild = false;
        playerCard45.haveAbility = false;
        playerCard45.IDtag = 44;
        playerDeck.Add(playerCard45);

        Card playerCard46 = new Card();
        playerCard46.color = "blue";
        playerCard46.number = 4;
        playerCard46.wild = false;
        playerCard46.haveAbility = false;
        playerCard46.IDtag = 45;
        playerDeck.Add(playerCard46);

        Card playerCard47 = new Card();
        playerCard47.color = "blue";
        playerCard47.number = 4;
        playerCard47.wild = false;
        playerCard47.haveAbility = false;
        playerCard47.IDtag = 46;
        playerDeck.Add(playerCard47);

        Card playerCard48 = new Card();
        playerCard48.color = "blue";
        playerCard48.number = 5;
        playerCard48.wild = false;
        playerCard48.haveAbility = false;
        playerCard48.IDtag = 47;
        playerDeck.Add(playerCard48);

        Card playerCard49 = new Card();
        playerCard49.color = "blue";
        playerCard49.number = 5;
        playerCard49.wild = false;
        playerCard49.haveAbility = false;
        playerCard49.IDtag = 48;
        playerDeck.Add(playerCard49);

        Card playerCard50 = new Card();
        playerCard50.color = "blue";
        playerCard50.number = 6;
        playerCard50.wild = false;
        playerCard50.haveAbility = false;
        playerCard50.IDtag = 49;
        playerDeck.Add(playerCard50);

        Card playerCard51 = new Card();
        playerCard51.color = "blue";
        playerCard51.number = 6;
        playerCard51.wild = false;
        playerCard51.haveAbility = false;
        playerCard51.IDtag = 50;
        playerDeck.Add(playerCard51);

        Card playerCard52 = new Card();
        playerCard52.color = "blue";
        playerCard52.number = 7;
        playerCard52.wild = false;
        playerCard52.haveAbility = false;
        playerCard52.IDtag = 51;
        playerDeck.Add(playerCard52);

        Card playerCard53 = new Card();
        playerCard53.color = "blue";
        playerCard53.number = 7;
        playerCard53.wild = false;
        playerCard53.haveAbility = false;
        playerCard53.IDtag = 52;
        playerDeck.Add(playerCard53);

        Card playerCard54 = new Card();
        playerCard54.color = "blue";
        playerCard54.number = 8;
        playerCard54.wild = false;
        playerCard54.haveAbility = false;
        playerCard54.IDtag = 53;
        playerDeck.Add(playerCard54);

        Card playerCard55 = new Card();
        playerCard55.color = "blue";
        playerCard55.number = 8;
        playerCard55.wild = false;
        playerCard55.haveAbility = false;
        playerCard55.IDtag = 54;
        playerDeck.Add(playerCard55);

        Card playerCard56 = new Card();
        playerCard56.color = "blue";
        playerCard56.number = 9;
        playerCard56.wild = false;
        playerCard56.haveAbility = false;
        playerCard56.IDtag = 55;
        playerDeck.Add(playerCard56);

        Card playerCard57 = new Card();
        playerCard57.color = "blue";
        playerCard57.number = 9;
        playerCard57.wild = false;
        playerCard57.haveAbility = false;
        playerCard57.IDtag = 56;
        playerDeck.Add(playerCard57);

        Card playerCard58 = new Card();
        playerCard58.color = "red";
        playerCard58.number = 10;
        playerCard58.wild = false;
        playerCard58.haveAbility = true;
        playerCard58.ability = "draw two";
        playerCard58.IDtag = 57;
        playerDeck.Add(playerCard58);

        Card playerCard59 = new Card();
        playerCard59.color = "red";
        playerCard59.number = 10;
        playerCard59.wild = false;
        playerCard59.haveAbility = true;
        playerCard59.ability = "draw two";
        playerCard59.IDtag = 58;
        playerDeck.Add(playerCard59);

        Card playerCard60 = new Card();
        playerCard60.color = "yellow";
        playerCard60.number = 10;
        playerCard60.wild = false;
        playerCard60.haveAbility = true;
        playerCard60.ability = "draw two";
        playerCard60.IDtag = 59;
        playerDeck.Add(playerCard60);

        Card playerCard61 = new Card();
        playerCard61.color = "yellow";
        playerCard61.number = 10;
        playerCard61.wild = false;
        playerCard61.haveAbility = true;
        playerCard61.ability = "draw two";
        playerCard61.IDtag = 60;
        playerDeck.Add(playerCard61);

        Card playerCard62 = new Card();
        playerCard62.color = "blue";
        playerCard62.number = 10;
        playerCard62.wild = false;
        playerCard62.haveAbility = true;
        playerCard62.ability = "draw two";
        playerCard62.IDtag = 61;
        playerDeck.Add(playerCard62);

        Card playerCard63 = new Card();
        playerCard63.color = "blue";
        playerCard63.number = 10;
        playerCard63.wild = false;
        playerCard63.haveAbility = true;
        playerCard63.ability = "draw two";
        playerCard63.IDtag = 62;
        playerDeck.Add(playerCard63);

        Card playerCard64 = new Card();
        playerCard64.color = "green";
        playerCard64.number = 10;
        playerCard64.wild = false;
        playerCard64.haveAbility = true;
        playerCard64.ability = "draw two";
        playerCard64.IDtag = 63;
        playerDeck.Add(playerCard64);

        Card playerCard65 = new Card();
        playerCard65.color = "green";
        playerCard65.number = 10;
        playerCard65.wild = false;
        playerCard65.haveAbility = true;
        playerCard65.ability = "draw two";
        playerCard65.IDtag = 64;
        playerDeck.Add(playerCard65);

        Card playerCard66 = new Card();
        playerCard66.color = "red";
        playerCard66.number = 11;
        playerCard66.wild = false;
        playerCard66.haveAbility = true;
        playerCard66.ability = "reverse";
        playerCard66.IDtag = 65;
        playerDeck.Add(playerCard66);

        Card playerCard67 = new Card();
        playerCard67.color = "red";
        playerCard67.number = 11;
        playerCard67.wild = false;
        playerCard67.haveAbility = true;
        playerCard67.ability = "reverse";
        playerCard67.IDtag = 66;
        playerDeck.Add(playerCard67);

        Card playerCard68 = new Card();
        playerCard68.color = "yellow";
        playerCard68.number = 11;
        playerCard68.wild = false;
        playerCard68.haveAbility = true;
        playerCard68.ability = "reverse";
        playerCard68.IDtag = 67;
        playerDeck.Add(playerCard68);

        Card playerCard69 = new Card();
        playerCard69.color = "yellow";
        playerCard69.number = 11;
        playerCard69.wild = false;
        playerCard69.haveAbility = true;
        playerCard69.ability = "reverse";
        playerCard69.IDtag = 68;
        playerDeck.Add(playerCard69);

        Card playerCard70 = new Card();
        playerCard70.color = "blue";
        playerCard70.number = 11;
        playerCard70.wild = false;
        playerCard70.haveAbility = true;
        playerCard70.ability = "reverse";
        playerCard70.IDtag = 69;
        playerDeck.Add(playerCard70);

        Card playerCard71 = new Card();
        playerCard71.color = "blue";
        playerCard71.number = 11;
        playerCard71.wild = false;
        playerCard71.haveAbility = true;
        playerCard71.ability = "reverse";
        playerCard71.IDtag = 70;
        playerDeck.Add(playerCard71);

        Card playerCard72 = new Card();
        playerCard72.color = "green";
        playerCard72.number = 11;
        playerCard72.wild = false;
        playerCard72.haveAbility = true;
        playerCard72.ability = "reverse";
        playerCard72.IDtag = 71;
        playerDeck.Add(playerCard72);

        Card playerCard73 = new Card();
        playerCard73.color = "green";
        playerCard73.number = 11;
        playerCard73.wild = false;
        playerCard73.haveAbility = true;
        playerCard73.ability = "reverse";
        playerCard73.IDtag = 72;
        playerDeck.Add(playerCard73);

        Card playerCard74 = new Card();
        playerCard74.color = "red";
        playerCard74.number = 12;
        playerCard74.wild = false;
        playerCard74.haveAbility = true;
        playerCard74.ability = "skip";
        playerCard74.IDtag = 73;
        playerDeck.Add(playerCard74);

        Card playerCard75 = new Card();
        playerCard75.color = "red";
        playerCard75.number = 12;
        playerCard75.wild = false;
        playerCard75.haveAbility = true;
        playerCard75.ability = "skip";
        playerCard75.IDtag = 74;
        playerDeck.Add(playerCard75);

        Card playerCard76 = new Card();
        playerCard76.color = "yellow";
        playerCard76.number = 12;
        playerCard76.wild = false;
        playerCard76.haveAbility = true;
        playerCard76.ability = "skip";
        playerCard76.IDtag = 75;
        playerDeck.Add(playerCard76);

        Card playerCard77 = new Card();
        playerCard77.color = "yellow";
        playerCard77.number = 12;
        playerCard77.wild = false;
        playerCard77.haveAbility = true;
        playerCard77.ability = "skip";
        playerCard77.IDtag = 76;
        playerDeck.Add(playerCard77);

        Card playerCard78 = new Card();
        playerCard78.color = "green";
        playerCard78.number = 12;
        playerCard78.wild = false;
        playerCard78.haveAbility = true;
        playerCard78.ability = "skip";
        playerCard78.IDtag = 77;
        playerDeck.Add(playerCard78);

        Card playerCard79 = new Card();
        playerCard79.color = "green";
        playerCard79.number = 12;
        playerCard79.wild = false;
        playerCard79.haveAbility = true;
        playerCard79.ability = "skip";
        playerCard79.IDtag = 78;
        playerDeck.Add(playerCard79);

        Card playerCard80 = new Card();
        playerCard80.color = "blue";
        playerCard80.number = 12;
        playerCard80.wild = false;
        playerCard80.haveAbility = true;
        playerCard80.ability = "skip";
        playerCard80.IDtag = 79;
        playerDeck.Add(playerCard80);

        Card playerCard81 = new Card();
        playerCard81.color = "blue";
        playerCard81.number = 12;
        playerCard81.wild = false;
        playerCard81.haveAbility = true;
        playerCard81.ability = "skip";
        playerCard81.IDtag = 80;
        playerDeck.Add(playerCard81);

        Card playerCard82 = new Card();
        playerCard82.color = "wild";
        playerCard82.number = 13;
        playerCard82.wild = true;
        playerCard82.haveAbility = false;
        playerCard82.IDtag = 81;
        playerDeck.Add(playerCard82);

        Card playerCard83 = new Card();
        playerCard83.color = "wild";
        playerCard83.number = 13;
        playerCard83.wild = true;
        playerCard83.haveAbility = false;
        playerCard83.IDtag = 82;
        playerDeck.Add(playerCard83);

        Card playerCard84 = new Card();
        playerCard84.color = "wild";
        playerCard84.number = 13;
        playerCard84.wild = true;
        playerCard84.haveAbility = false;
        playerCard84.IDtag = 83;
        playerDeck.Add(playerCard84);


        Card playerCard85 = new Card();
        playerCard85.color = "wild";
        playerCard85.number = 13;
        playerCard85.wild = true;
        playerCard85.haveAbility = false;
        playerCard85.IDtag = 84;
        playerDeck.Add(playerCard85);

        Card playerCard86 = new Card();
        playerCard86.color = "wild four";
        playerCard86.number = 14;
        playerCard86.wild = true;
        playerCard86.haveAbility = true;
        playerCard86.ability = "draw four";
        playerCard86.IDtag = 85;
        playerDeck.Add(playerCard86);

        Card playerCard87 = new Card();
        playerCard87.color = "wild four";
        playerCard87.number = 14;
        playerCard87.wild = true;
        playerCard87.haveAbility = true;
        playerCard87.ability = "draw four";
        playerCard87.IDtag = 86;
        playerDeck.Add(playerCard87);

        Card playerCard88 = new Card();
        playerCard88.color = "wild four";
        playerCard88.number = 14;
        playerCard88.wild = true;
        playerCard88.haveAbility = true;
        playerCard88.ability = "draw four";
        playerCard88.IDtag = 87;
        playerDeck.Add(playerCard88);

        Card playerCard89 = new Card();
        playerCard89.color = "wild four";
        playerCard89.number = 14;
        playerCard89.wild = true;
        playerCard89.haveAbility = true;
        playerCard89.ability = "draw four";
        playerCard89.IDtag = 88;
        playerDeck.Add(playerCard89);

        Card playerCard90 = new Card();
        playerCard90.color = "green";
        playerCard90.number = 0;
        playerCard90.wild = false;
        playerCard90.haveAbility = true;
        playerCard90.IDtag = 89;
        playerDeck.Add(playerCard90);

        Card playerCard91 = new Card();
        playerCard91.color = "green";
        playerCard91.number = 1;
        playerCard91.wild = false;
        playerCard91.haveAbility = true;
        playerCard91.IDtag = 90;
        playerDeck.Add(playerCard90);

        Card playerCard92 = new Card();
        playerCard92.color = "green";
        playerCard92.number = 1;
        playerCard92.wild = false;
        playerCard92.haveAbility = true;
        playerCard92.IDtag = 91;
        playerDeck.Add(playerCard92);

        Card playerCard93 = new Card();
        playerCard93.color = "green";
        playerCard93.number = 2;
        playerCard93.wild = false;
        playerCard93.haveAbility = true;
        playerCard93.IDtag = 92;
        playerDeck.Add(playerCard93);

        Card playerCard94 = new Card();
        playerCard94.color = "green";
        playerCard94.number = 2;
        playerCard94.wild = false;
        playerCard94.haveAbility = true;
        playerCard94.IDtag = 93;
        playerDeck.Add(playerCard94);

        Card playerCard95 = new Card();
        playerCard95.color = "green";
        playerCard95.number = 3;
        playerCard95.wild = false;
        playerCard95.haveAbility = true;
        playerCard95.IDtag = 94;
        playerDeck.Add(playerCard95);

        Card playerCard96 = new Card();
        playerCard96.color = "green";
        playerCard96.number = 3;
        playerCard96.wild = false;
        playerCard96.haveAbility = true;
        playerCard96.IDtag = 95;
        playerDeck.Add(playerCard96);

        Card playerCard97 = new Card();
        playerCard97.color = "green";
        playerCard97.number = 4;
        playerCard97.wild = false;
        playerCard97.haveAbility = true;
        playerCard97.IDtag = 96;
        playerDeck.Add(playerCard97);

        Card playerCard98 = new Card();
        playerCard98.color = "green";
        playerCard98.number = 4;
        playerCard98.wild = false;
        playerCard98.haveAbility = true;
        playerCard98.IDtag = 97;
        playerDeck.Add(playerCard98);

        Card playerCard99 = new Card();
        playerCard99.color = "green";
        playerCard99.number = 5;
        playerCard99.wild = false;
        playerCard99.haveAbility = true;
        playerCard98.IDtag = 97;
        playerDeck.Add(playerCard99);

        Card playerCard100 = new Card();
        playerCard100.color = "green";
        playerCard100.number = 5;
        playerCard100.wild = false;
        playerCard100.haveAbility = true;
        playerCard100.IDtag = 99;
        playerDeck.Add(playerCard100);

        Card playerCard101 = new Card();
        playerCard101.color = "green";
        playerCard101.number = 6;
        playerCard101.wild = false;
        playerCard101.haveAbility = true;
        playerCard101.IDtag = 100;
        playerDeck.Add(playerCard101);

        Card playerCard102 = new Card();
        playerCard102.color = "green";
        playerCard102.number = 6;
        playerCard102.wild = false;
        playerCard102.haveAbility = true;
        playerCard102.IDtag = 101;
        playerDeck.Add(playerCard102);

        Card playerCard103 = new Card();
        playerCard103.color = "green";
        playerCard103.number = 7;
        playerCard103.wild = false;
        playerCard103.haveAbility = true;
        playerCard103.IDtag = 102;
        playerDeck.Add(playerCard103);

        Card playerCard104 = new Card();
        playerCard104.color = "green";
        playerCard104.number = 7;
        playerCard104.wild = false;
        playerCard104.haveAbility = true;
        playerCard104.IDtag = 103;
        playerDeck.Add(playerCard104);

        Card playerCard105 = new Card();
        playerCard105.color = "green";
        playerCard105.number = 8;
        playerCard105.wild = false;
        playerCard105.haveAbility = true;
        playerCard105.IDtag = 104;
        playerDeck.Add(playerCard105);

        Card playerCard106 = new Card();
        playerCard106.color = "green";
        playerCard106.number = 8;
        playerCard106.wild = false;
        playerCard106.haveAbility = true;
        playerCard106.IDtag = 105;
        playerDeck.Add(playerCard106);

        Card playerCard107 = new Card();
        playerCard107.color = "green";
        playerCard107.number = 9;
        playerCard107.wild = false;
        playerCard107.haveAbility = true;
        playerCard107.IDtag = 106;
        playerDeck.Add(playerCard107);

        Card playerCard108 = new Card();
        playerCard108.color = "green";
        playerCard108.number = 9;
        playerCard108.wild = false;
        playerCard108.haveAbility = true;
        playerCard108.IDtag = 107;
        playerDeck.Add(playerCard108);



        //adding all the Gameobject Cards to a vector (list).
        deck.Add(Card1);
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



        //Add top card of the deck to the drawn pile and than remove it from the decks list
        drawnPile.Add(playerDeck[playerDeck.Count - 1]);
        playerDeck.RemoveAt(playerDeck.Count - 1);
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
        DeckCard.active = true;
        StartButton.active = false;
        PlayerArea.active = true;

        //Turning on the placeholder cards for the AI
        AiCard1.active = true;
        AiCard2.active = true;
        AiCard3.active = true;


        //Shuffle the deck before the game starts
        playerDeck = Shuffle(playerDeck);

 
 
        //GamerTracker will be a List of type List to track the game
        gamerTracker.Add(AI1Hand);
        gamerTracker.Add(AI2Hand);
        gamerTracker.Add(AI3Hand);
        gamerTracker.Add(playerHand);

        //Deal out Cards to each player and AI
        for (int i = 0; i < 7; i++)
        {

            //Player cards getting displayed
            playerHand = DrawCard(playerHand);
            GameObject PlayerCard = Instantiate(deck[playerHand[i].IDtag], new Vector3(0, 0, 0), Quaternion.identity);
            PlayerCard.transform.SetParent(PlayerArea.transform, false);

            PlayerCard.name = playerHand[i].IDtag.ToString();
            PlayerCard.name = "Card" + PlayerCard.name;
            cardClones.Add(PlayerCard);

            //AI currently don't display cards
            AI1Hand = DrawCard(AI1Hand);
            AI2Hand = DrawCard(AI2Hand);
            AI3Hand = DrawCard(AI3Hand);
        }

        //Drawing the first card for the DrawnPile.
        GameObject DrawPile = Instantiate(deck[playerDeck[playerDeck.Count - 1].IDtag], new Vector3(0, 0, 0), Quaternion.identity);
        DrawPile.transform.SetParent(DrawnPile.transform, false);
        drawnPile.Add(playerDeck[playerDeck.Count - 1]);
        playerDeck.RemoveAt(playerDeck.Count - 1);
        drawnObjectPile.Add(DrawPile);


        for (int i = 0, j = 0,r = 0; i < 50; i++)
        {
            i = i + j;
            r++; 
       
            if (r > 2)
            {
                r = 0;
            }
            if (playerDeck.Count -1 == 0)
            {
                playerDeck = Shuffle(playerDeck);
            }
               
            if (r == 0 || r == 1 || r == 2)
            {
                //First create a new tempList to access each "players hand"
                List<Card> tempList = gamerTracker[r];

                if (tempList.Count - 1 == 0)
                {
                    i = i + 101;
                    AI1CardCount.text = AI1Hand.Count.ToString();
                    break;
                }
                    
                for (int t = 0; t < tempList.Count - 1; t++)
                { 

                    if (tempList[t].number == drawnPile[drawnPile.Count - 1].number || tempList[t].color == drawnPile[drawnPile.Count - 1].color || tempList[t].wild == true)
                    {

                        if (tempList[t].wild == true)
                        {
                            tempList[t].color = "blue";                              
                        }

                        //playing whatever card is being played.
                        drawnPile.Add(tempList[t]);

                        //Removing the Card from hand 
                        tempList.RemoveAt(t);

                        //playing physical card on the "DrawPile"
                        DrawPile = Instantiate(deck[tempList[t].IDtag], new Vector3(0, 0, 0), Quaternion.identity);
                        DrawPile.transform.SetParent(DrawnPile.transform, false);
                        drawnObjectPile.Add(DrawPile);

                        Debug.Log("it might be okay");


                        AI1CardCount.text = AI1Hand.Count.ToString();
                        AI2CardCount.text = AI2Hand.Count.ToString();
                        AI3CardCount.text = AI3Hand.Count.ToString();
                        r = r + 1;
                        t = tempList.Count;
                        break;       
                        
                    }

                    if (t == tempList.Count - 1)
                    {
                    
                        DrawCard(tempList);
                        t = tempList.Count;
                        r = r + 1;
                        break;

                    }
                }
            }
        }
    }
    public List<Card> DrawCard(List<Card> hand)
    {
        /* 
        * We are going to treat the "top" of the deck equal to the end of the list. 
        */

        hand.Add(playerDeck[playerDeck.Count -1]);
        playerDeck.RemoveAt(playerDeck.Count -1);

        return hand;
    }

    public List<Card> Shuffle(List<Card> deck)
    {
  
        List<Card> cardsVec = new List<Card>();
        List<Card> tempCards = new List<Card>();


        foreach (var item in deck)
        {
            cardsVec.Add(item);
        }

        foreach (var item in deck)
        {
            Card randomCard = cardsVec[Random.Range(0, cardsVec.Count)];
            int index = cardsVec.IndexOf(randomCard);

            tempCards.Add(randomCard);
            cardsVec.RemoveAt(index);
        }

        deck.Clear();
        deck = tempCards;
        return deck;
    }

    public bool CanBePlayed()
    {

        Card foundcopy = new Card();

        for(int i =0; i < drawnObjectPile.Count - 1; i++)
        {
            if(cardClones[i] == DrawnPile.transform.GetChild(i).gameObject)
            {
                foundcopy = playerHand[i];
                cardClones.RemoveAt(i);
                playerHand.RemoveAt(i);
            }

        }



        foreach (GameObject card in drawnObjectPile)
        {
            int counter = drawnObjectPile.IndexOf(card);

            if(drawnObjectPile.IndexOf(card) == playerObjectHand.IndexOf(card))
            {
                return true;
                Debug.Log("it worked thank christ");
            }
        }

        return false;
    }


    
}


