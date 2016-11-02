using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreditsScript : MonoBehaviour {
	/**
		Current Menu:
		creditsMenu

		Super Menus:
		mainMenu

		Sub Menus:
		NONE
	**/

	// Interactables:
	public Text backButton;

	void Start () {
		// Get all interactables
		backButton = backButton.GetComponent<Text> ();
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.CreditsMenu, (int)MenuManager.Menus.MainMenu, false, false);
	}

	public void enableButtons() {
		backButton.enabled = true;
		backButton.gameObject.GetComponent<Button> ().enabled = true;
	}

	public void disableButtons() {
		backButton.enabled = false;
		backButton.gameObject.GetComponent<Button> ().enabled = false;
	}
}
