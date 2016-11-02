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
	public Text titleText;
	public Text backButton;

	void Start () {
		// Get all interactables
		titleText = titleText.GetComponent<Text> ();
		backButton = backButton.GetComponent<Text> ();
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.CreditsMenu, (int)MenuManager.Menus.MainMenu, false, false);
	}

	public void enableButtons() {
		/*titleText.enabled = true;
		backButton.enabled = true;*/
		backButton.gameObject.GetComponent<Button> ().enabled = true;
	}

	public void disableButtons() {
		/*titleText.enabled = false;
		backButton.enabled = false;*/
		backButton.gameObject.GetComponent<Button> ().enabled = false;
	}
}
