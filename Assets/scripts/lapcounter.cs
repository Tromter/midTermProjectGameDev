using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lapcounter : MonoBehaviour {

	Text myText;

	public GameObject player1;
	public GameObject player2;

	public PlayerMovement p1play;
	public Player2Movement p2play;


	// Use this for initialization
	void Start () {
		GameObject player1 = GameObject.FindGameObjectWithTag ("Player1");
		GameObject player2 = GameObject.FindGameObjectWithTag ("Player2");

		PlayerMovement p1play = player1.GetComponent<PlayerMovement>();
		Player2Movement p2play = player2.GetComponent<Player2Movement> ();

		GetComponent<Text>().text = "";
		myText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Red Lap: " + p1play.currentLap.ToString () + "/3" + "\n" + "Blue Lap: " + p2play.currentLap.ToString ()+ "/3";
	}
}
