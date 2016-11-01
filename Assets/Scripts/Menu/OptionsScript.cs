using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsScript : MonoBehaviour {
	
	// Current Menu:
	public Canvas optionsMenu;

	// Super Menus:
	public Canvas mainMenu;

	// Sub Menus:
	public Canvas audioMenu;
	public Canvas graphicsMenu;
	public Canvas controlsMenu;

	// Interactables:
	public Button audioButton;
	public Button graphicsButton;
	public Button controlsButton;
	public Button backButton;

	void Start () {
		
		// Get all menu screens
		optionsMenu = optionsMenu.GetComponent<Canvas> ();
		mainMenu = mainMenu.GetComponent<Canvas> ();
		audioMenu = audioMenu.GetComponent<Canvas> ();
		graphicsMenu = graphicsMenu.GetComponent<Canvas> ();
		controlsMenu = controlsMenu.GetComponent<Canvas> ();

		// Get all interactables
		audioButton = audioButton.GetComponent<Button> ();
		graphicsButton = graphicsButton.GetComponent<Button> ();
		controlsButton = controlsButton.GetComponent<Button> ();
		backButton = backButton.GetComponent<Button> ();

		optionsMenu.enabled = false;
	}

	public void Init () {
		optionsMenu.enabled = true;

		audioMenu.enabled = false;
		graphicsMenu.enabled = false;
		controlsMenu.enabled = false;

		audioButton.enabled = true;
		graphicsButton.enabled = true;
		controlsButton.enabled = true;
		backButton.enabled = true;
	}

	void Update () {
		// Nothing
	}

	public void AudioPress() {
		audioButton.enabled = false;
		graphicsButton.enabled = false;
		controlsButton.enabled = false;
		backButton.enabled = false;

		audioMenu.GetComponent<AudioScript> ().Init ();
	}

	public void GraphicsPress() {
		audioButton.enabled = false;
		graphicsButton.enabled = false;
		controlsButton.enabled = false;
		backButton.enabled = false;

		graphicsMenu.GetComponent<GraphicsScript> ().Init ();
	}

	public void ControlsPress() {
		audioButton.enabled = false;
		graphicsButton.enabled = false;
		controlsButton.enabled = false;
		backButton.enabled = false;

		controlsMenu.GetComponent<ControlsScript> ().Init ();
	}

	public void BackPress () {
		optionsMenu.enabled = false;
		mainMenu.GetComponent<MenuScript> ().Init ();
	}
}
