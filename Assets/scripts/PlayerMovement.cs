using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float windThrust;
	public Rigidbody rb;
	public Transform target;
	public float testhelper;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		windThrust = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)){
			transform.localEulerAngles += new Vector3( 0f, -90f * Time.deltaTime, 0f );
		}

		if (Input.GetKey (KeyCode.D)){
			transform.localEulerAngles += new Vector3( 0f, 90f * Time.deltaTime, 0f );
		}

		float windangle = Quaternion.Angle(transform.rotation, target.rotation);
		Debug.Log (windangle);


		if (windangle > 0 && windangle <= 90){
			windThrust = windangle;
		}
		else if (windangle > 90 && windangle <= 180){
			windThrust = Mathf.Abs (windangle - 180);
		}
		else if (windangle > 180 && windangle <= 270){
			windangle = windangle - 10;
			windThrust = Mathf.Abs (windangle - 180);
		}
		else if (windangle > 270 && windangle <= 360){
			windangle = windangle - 10;
			windThrust = Mathf.Abs (windangle - 360);
		}
			
		if (windThrust > 60){
			windThrust = windThrust - 10;
		}
		rb.velocity = transform.forward * windThrust * Time.deltaTime * testhelper;
	}
}
