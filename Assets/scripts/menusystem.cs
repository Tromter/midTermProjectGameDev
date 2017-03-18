using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menusystem : MonoBehaviour {

	public Button menu;
	public Button replay;

	// Use this for initialization
	void Start () {
		menu = menu.GetComponent<Button> ();
		replay = replay.GetComponent<Button> ();

	}

	public void GameStart(){
		SceneManager.LoadScene ("SailScene1");
	}

	public void menupress(){
		SceneManager.LoadScene ("menuscene");
	}
}
