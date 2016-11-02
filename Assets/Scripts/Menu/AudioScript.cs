using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioScript : MonoBehaviour {
	/**
		Current Menu:
		audioMenu

		Super Menus:
		optionsMenu

		Sub Menus:
		NONE
	**/

	// Interactables:
	public Text backButton;

	public Image screen;
	public Transform camera;

	void Start () {
		// Get all interactables
		backButton = backButton.GetComponent<Text> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.AudioMenu, (int)MenuManager.Menus.OptionsMenu, true, false);
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
