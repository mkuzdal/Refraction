using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	/**
		Current Menu:
		mainMenu

		Super Menus:
		NONE

		Sub Menus:
		playMenu
		optionsMenu
		creditsMenu
		exitMenu
	**/

	// Interactables:
	public Text titleText;
	public Text playButton;
	public Text optionsButton;
	public Text creditsButton;
	public Text exitButton;

	void Start () {
		// Get all interactables:
		titleText = titleText.GetComponent<Text> ();
		playButton = playButton.GetComponent<Text> ();
		optionsButton = optionsButton.GetComponent<Text> ();
		creditsButton = creditsButton.GetComponent<Text> ();
		exitButton = exitButton.GetComponent<Text> ();
	}

	void Update() {
		// Nothing
	}
		
	public void PlayPress() {
		// Application.LoadLevel(1);
	}

	public void OptionsPress() {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.MainMenu, (int)MenuManager.Menus.OptionsMenu, false, false);
	}

	public void CreditsPress() {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.MainMenu, (int)MenuManager.Menus.CreditsMenu, false, false);
	}
	
	public void ExitPress() {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.MainMenu, (int)MenuManager.Menus.ExitMenu, false, true);
	}

	public void enableButtons() {
		/*titleText.enabled = true;
		playButton.enabled = true;
		optionsButton.enabled = true;
		creditsButton.enabled = true;
		exitButton.enabled = true;*/
		playButton.gameObject.GetComponent<Button> ().enabled = true;
		optionsButton.gameObject.GetComponent<Button> ().enabled = true;
		creditsButton.gameObject.GetComponent<Button> ().enabled = true;
		exitButton.gameObject.GetComponent<Button> ().enabled = true;
	}

	public void disableButtons() {
		/*titleText.enabled = false;
		playButton.enabled = false;
		optionsButton.enabled = false;
		creditsButton.enabled = false;
		exitButton.enabled = false;*/
		playButton.gameObject.GetComponent<Button> ().enabled = false;
		optionsButton.gameObject.GetComponent<Button> ().enabled = false;
		creditsButton.gameObject.GetComponent<Button> ().enabled = false;
		exitButton.gameObject.GetComponent<Button> ().enabled = false;
	}

}
