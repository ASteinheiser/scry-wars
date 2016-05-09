using UnityEngine;
using System.Collections;

namespace CustomScripts{

	public class Deck{
		GameObject deckObject;
		Vector3 startPosition;
		public ArrayList deck;

		public Deck () {
			deck = new ArrayList ();
			startPosition = new Vector3 (8.5f, -3, 0);
		}
		public void CreateDeck() {
			deckObject = new GameObject ("deckObject");
			deckObject.AddComponent<BoxCollider> ();
			deckObject.AddComponent<SpriteRenderer>().sprite = (Sprite) Resources.Load <Sprite>("blue");
			deckObject.GetComponent<SpriteRenderer> ().sortingOrder = 1;
			deckObject.transform.position = startPosition;
			deckObject.transform.localScale = new Vector3 (0.04f, 0.1f, 0);
		}
		public ArrayList GetDeck() {
			return deck;
		}
		public void AddCard(Card card) {
			deck.Add (card);
		}
	}

	public class Card{
		GameObject cardObject;
		string name;
		Vector3 startPosition;

		public Card (string name) {
			this.name = name;
			startPosition = new Vector3 (15, 15, 0);
		}
		public void CreateCard () {
			cardObject = new GameObject (name);
			cardObject.AddComponent<BoxCollider> ();
			cardObject.AddComponent<SpriteRenderer>().sprite = (Sprite) Resources.Load <Sprite>(name);
			cardObject.transform.position = startPosition;
		}
	}

	public class Player{
		int health;
		Deck deck;
		int cardsInHand;
		public Player () {
			health = 500;
			cardsInHand = 0;
		}
		public void CreateDeck () {
			deck = new Deck ();
			deck.CreateDeck ();
		}
	}
}
