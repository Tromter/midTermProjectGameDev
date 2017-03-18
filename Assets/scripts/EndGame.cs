using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public PlayerMovement p1play;
	public Player2Movement p2play;

	public Canvas redwins;
	public Canvas bluewins;

	// Use this for initialization
	void Start () {
		GameObject player1 = GameObject.FindGameObjectWithTag ("Player1");
		GameObject player2 = GameObject.FindGameObjectWithTag ("Player2");

		PlayerMovement p1play = player1.GetComponent<PlayerMovement>();
		Player2Movement p2play = player2.GetComponent<Player2Movement> ();

		redwins = redwins.GetComponent<Canvas> ();
		bluewins = bluewins.GetComponent<Canvas> ();


		redwins.enabled = false;
		bluewins.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (p1play.winstate == true){
			redwins.enabled = true;
			Time.timeScale = 0;

		}
		if (p2play.winstate == true){
			bluewins.enabled = true;
			Time.timeScale = 0;
		}



	}
}
