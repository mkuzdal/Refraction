using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CreditsScript : MonoBehaviour {

	// Current Menu Screen:
	public Canvas creditsMenu;

	// Super Menus:
	public Canvas mainMenu;

	// Sub Menus:
	// NONE

	// Interactables:
	public Button backButton;

	void Start () {
		// Get all menu screens
		creditsMenu = creditsMenu.GetComponent<Canvas> ();
		mainMenu = mainMenu.GetComponent<Canvas> ();

		// Get all interactables
		backButton = backButton.GetComponent<Button> ();

		creditsMenu.enabled = false;
	}

	public void Init () {
		creditsMenu.enabled = true;
		mainMenu.enabled = false;
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		mainMenu.GetComponent<MenuScript> ().Init ();
	}
}
