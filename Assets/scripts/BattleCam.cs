using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCam : MonoBehaviour {

	private Vector3 WantedPos = new Vector3 (0, 0, 0);
	public Transform[] targets;
	public float yea = 5;

	void Update () {
		//Get midpoint between the two first
		WantedPos = ((targets[1].position/2 + targets[0].position/2));
		WantedPos.y = 10;

		//Make a vector for camera to look at.
		Vector3 newVector = ((targets[0].position - targets[1].position) + new Vector3(20, -25, 40));

		//Make a vector backwards
		Vector3 TempMe = new Vector3 (transform.position.x, targets[0].position.y, transform.position.z);
		Vector3 temp = ((targets [0].position - WantedPos)*yea);
		//Don't want it messing with out y position
		temp.y = 0;

		Vector3 TempT = WantedPos - temp;

		//Rotates and Positions camera around a point
		transform.rotation = Quaternion.LookRotation (newVector);
		transform.position = TempT;

	}
}