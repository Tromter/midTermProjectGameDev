using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public Canvas startMenu;
	public Canvas instructionMenu;
	public Button startText;
	public Button exitText;
	public Button instructionText;
	// Use this for initialization
	void Start () {

		instructionMenu = instructionMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		instructionText = instructionText.GetComponent<Button> ();
		instructionMenu.enabled = false;

		
	}

	public void InstructPressed()
	{
		instructionMenu.enabled = true;
		startMenu.enabled = false;
	}

	public void GoodLuckPress()
	{
		instructionMenu.enabled = false;
		startMenu.enabled = true;
	}

	public void GameStart(){
		SceneManager.LoadScene ("SailScene1");
	}

	public void exitGame()
	{
		Application.Quit ();
	}

}
