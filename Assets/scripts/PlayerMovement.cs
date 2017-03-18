using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	private float windThrust;
	public Rigidbody rb;
	public float testhelper;

	public GameObject mainship;
	private bool movement = true;

	public GameObject[] checkPointArray;
	public int currentCheck = 0;
	public int currentLap = 0;
	public int arrayLength;

	private GameObject targetObject;
	private Transform target;

	private float helper = 0;

	public bool winstate = false;


	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		windThrust = 0;

		arrayLength = checkPointArray.Length;

		movement = true;

		//sound effect


	}
	
	// Update is called once per frame
	void Update ()
	{

		if(currentLap >= 4){
			winstate = true;
		}

		target = findWind ();


			
		if (Input.GetKey (KeyCode.A)) {
			transform.localEulerAngles += new Vector3 (0f, -90f * Time.deltaTime, 0f);
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.localEulerAngles += new Vector3 (0f, 90f * Time.deltaTime, 0f);
		}

		float windangle = Quaternion.Angle (transform.rotation, target.rotation);




		if (movement == true) {

			if (windangle > 0 && windangle <= 90) {
				windThrust = windangle;
			} else if (windangle > 90 && windangle <= 180) {
				windThrust = Mathf.Abs (windangle - 180);
			} else if (windangle > 180 && windangle <= 270) {
				windangle = windangle - 10;
				windThrust = Mathf.Abs (windangle - 180);
			} else if (windangle > 270 && windangle <= 360) {
				windangle = windangle - 10;
				windThrust = Mathf.Abs (windangle - 360);
			}
			
			if (windThrust > 60) {
				windThrust = windThrust - 10;
			}
			rb.velocity = transform.forward * windThrust * Time.deltaTime * testhelper;
		}

		if (movement == false) {
			if (Input.GetKey (KeyCode.F)){
				mainship.transform.Rotate (0f, 0f, 90f * Time.deltaTime);
				helper += 90f * Time.deltaTime;
			}
					
			if (helper >= 170f){
					movement = true;
					mainship.transform.localEulerAngles = new Vector3 (0f, 0f, 0f);
			}
		}

	}

	public Transform findWind ()
	{
		if (GameObject.FindGameObjectWithTag ("WindMaster") == true) {
			GameObject targetObject = GameObject.FindGameObjectWithTag ("WindMaster");
			Transform target = targetObject.transform;
			return target;
		} else {
			return null;

		}
	}

	void OnCollisionEnter (Collision other)
	{



		if (other.collider) {
			
			windThrust = 0f;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			movement = false;

			Vector3 direction = mainship.transform.position - other.transform.position;
			direction.Normalize ();

			transform.position = mainship.transform.position + (direction * 2);

			//sound here

			mainship.transform.Rotate (0f, 0f, 180f);

		}

	}
		
}
