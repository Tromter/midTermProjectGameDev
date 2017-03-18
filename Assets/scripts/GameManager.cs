using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

	public GameObject timerCanvas;
	public Text clockDisplayText;

	public GameObject[] windzones;
	public int windarrayLength;

	public GameObject windmaster;

	public bool gameStart = false;
	public float countDown = 5f;
	public bool firstpost = false;

	public Transform pointerlocation;
	public GameObject pointer;








	// Use this for initialization
	void Start () {
//		GetComponent<Text>().text= "";
		clockDisplayText = GameObject.Find("mainHUDDisplay").GetComponent<Text> ();

		Debug.Log (windarrayLength);

		
	}
	
	// Update is called once per frame
	void Update () {
		countDown -= Time.deltaTime;
		int displayDown = (int)countDown;
		clockDisplayText.text = displayDown.ToString();



		if (countDown < 0f)
		{
			gameStart = true;
			clockDisplayText.text = "";
			if (firstpost == false)
			{
				startClock ();
			}
		}
	}

	void startClock(){
//		if (gameStart == true)
		GameObject.Instantiate (timerCanvas);
		firstpost = true;
		int windnumber = Random.Range (0, windarrayLength);
		Debug.Log ("The windnumber:" + windnumber);
		Vector3 windposition = windzones [windnumber].transform.position;
		Quaternion winddirection = windzones [windnumber].transform.rotation;
		Vector3 pointerspot = pointerlocation.position;
		Instantiate (windmaster, windposition, winddirection);
		Instantiate (pointer, pointerspot, winddirection); 



	}

}
