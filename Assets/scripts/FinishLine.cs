using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {


	public Text myText;

	void OnTriggerEnter ( Collider other ) {
		if (other.gameObject.name == "player1"){
			myText.text = "Player 1 wins!";
			
		}
		else if(other.gameObject.name == "player2"){
			myText.text = "Player 2 wins!";
		}
	}

}
