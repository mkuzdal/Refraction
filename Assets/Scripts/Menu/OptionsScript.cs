using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsScript : MonoBehaviour {
	/**
		Current Menu:
		optionsMenu

		Super Menus:
		mainMenu

		Sub Menus:
		audioMenu
		graphicsMenu
		controlsMenu 
	**/

	// Interactables:
	public Text audioButton;
	public Text graphicsButton;
	public Text controlsButton;
	public Text backButton;

	void Start () {
		// Get all interactables
		audioButton = audioButton.GetComponent<Text> ();
		graphicsButton = graphicsButton.GetComponent<Text> ();
		controlsButton = controlsButton.GetComponent<Text> ();
		backButton = backButton.GetComponent<Text> ();

	}

	void Update () {
		// Nothing
	}

	public void AudioPress() {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.OptionsMenu, (int)MenuManager.Menus.AudioMenu, false, true);
	}

	public void GraphicsPress() {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.OptionsMenu, (int)MenuManager.Menus.GraphicsMenu, false, true);
	}

	public void ControlsPress() {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.OptionsMenu, (int)MenuManager.Menus.ControlsMenu, false, true);
	}

	public void BackPress () {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.OptionsMenu, (int)MenuManager.Menus.MainMenu, false, false);
	}

	public void enableButtons() {
		audioButton.enabled = true;
		graphicsButton.enabled = true;
		controlsButton.enabled = true;
		backButton.enabled = true;
		audioButton.gameObject.GetComponent<Button> ().enabled = true;
		graphicsButton.gameObject.GetComponent<Button> ().enabled = true;
		controlsButton.gameObject.GetComponent<Button> ().enabled = true;
		backButton.gameObject.GetComponent<Button> ().enabled = true;
	}

	public void disableButtons() {
		audioButton.enabled = false;
		graphicsButton.enabled = false;
		controlsButton.enabled = false;
		backButton.enabled = false;
		audioButton.gameObject.GetComponent<Button> ().enabled = false;
		graphicsButton.gameObject.GetComponent<Button> ().enabled = false;
		controlsButton.gameObject.GetComponent<Button> ().enabled = false;
		backButton.gameObject.GetComponent<Button> ().enabled = false;
	}

}
