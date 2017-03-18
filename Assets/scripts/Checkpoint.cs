using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

//	public Transform player1;
//	public Transform player2;

	public GameObject player1;
	public GameObject player2;

	public PlayerMovement p1play;
	public Player2Movement p2play;

	private int p1currentcheck;


	// Use this for initialization
	void Start () {
	
		GameObject player1 = GameObject.FindGameObjectWithTag ("Player1");
		GameObject player2 = GameObject.FindGameObjectWithTag ("Player2");

		PlayerMovement p1play = player1.GetComponent<PlayerMovement>();
		Player2Movement p2play = player2.GetComponent<Player2Movement> ();
		
	}

//	void Update(){
//		if (p1play.winstate == true){
//			
//		}
//		if (p1play.winstate == true){
//			
//		}
//
//	}

	void OnTriggerEnter(Collider other){
		if (!other.CompareTag ("Player1") && !other.CompareTag ("Player2")){
			return;
		}

		if (other.CompareTag ("Player1")){
			Debug.Log (transform == p1play.checkPointArray [p1play.currentCheck].transform);

			if (transform == p1play.checkPointArray[p1play.currentCheck].transform){
				if (p1play.currentCheck + 1 < p1play.arrayLength) {
					if (p1play.currentCheck == 0) {
						p1play.currentLap++;
						Debug.Log(p1play.currentLap);
					}
					p1play.currentCheck++;
				}
				else {
					p1play.currentCheck = 0;
					}
				}
			}
		else if (other.CompareTag ("Player2")){
			if (transform == p2play.checkPointArray[p2play.currentCheck].transform){
				if (p2play.currentCheck + 1 < p2play.arrayLength) {
					if (p2play.currentCheck == 0) {
						p2play.currentLap++;
					}
					p2play.currentCheck++;
				}
				else {
						p2play.currentCheck = 0;
					}
				}
			}
		}
}
