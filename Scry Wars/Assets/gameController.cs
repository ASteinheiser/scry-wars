using UnityEngine;
using System.Collections;

using CustomScripts;

public class gameController : MonoBehaviour {

	Player player1;

	void Start () {
		player1 = new Player ();
		player1.CreateDeck ();
	}

	void Update () {
	
	}
}
