using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	Text myText;
	private float startTime;
//
//	public GameObject player1;
//	public GameObject player2;
//
//	public PlayerMovement p1play;
//	public Player2Movement p2play;
//
//	public Canvas othercanvas1;
//	public Canvas othercanvas2;
//	public Canvas othercanvas3;
//	public Canvas redwins;
//	public Canvas bluewins;
//
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		GetComponent<Text>().text = "";
		myText = GetComponent<Text>();

//		GameObject player1 = GameObject.FindGameObjectWithTag ("Player1");
//		GameObject player2 = GameObject.FindGameObjectWithTag ("Player2");
//
//		PlayerMovement p1play = player1.GetComponent<PlayerMovement>();
//		Player2Movement p2play = player2.GetComponent<Player2Movement> ();
	}

	// Update is called once per frame
	void Update () {
		float finalTime = Time.time - startTime;
		myText.text = finalTime.ToString ("F");
		//myText.text = Time.time.ToString("F3");

	}

}
