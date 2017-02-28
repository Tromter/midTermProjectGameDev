using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	Text myText;

	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = "";
		myText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		myText.text = Time.time.ToString("F3");
	}

}
