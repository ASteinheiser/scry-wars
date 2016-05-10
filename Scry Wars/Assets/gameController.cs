using UnityEngine;
using System.Collections;

using CustomScripts;

public class gameController : MonoBehaviour {

	Player player1;

	void Start () {
		player1 = new Player ();
		player1.CreateDeck ();

		Deck deck1 = player1.getDeck ();

		Card card1 = new Card("card1");
		Card card2 = new Card("card2");
		Card card3 = new Card("card3");
		Card card4 = new Card("card4");
		Card card5 = new Card("card5");

		deck1.AddCard (card1);
		deck1.AddCard (card2);
		deck1.AddCard (card3);
		deck1.AddCard (card4);
		deck1.AddCard (card5);

		card1.CreateCard ();
	}

	void Update () {
	
	}
}
