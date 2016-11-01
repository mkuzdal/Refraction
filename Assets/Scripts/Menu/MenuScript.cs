using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	// Current Menu:
	public Canvas mainMenu;

	// Super Menus:
	// NONE

	// Sub Menus:
	public Canvas playMenu;
	public Canvas optionsMenu;
	public Canvas creditsMenu;
	public Canvas exitMenu;

	// Interactables:
	public Button playButton;
	public Button optionsButton;
	public Button creditsButton;
	public Button exitButton;

	void Start () {
		// Get all menu screens:
		mainMenu = mainMenu.GetComponent<Canvas> ();

		playMenu = playMenu.GetComponent<Canvas> ();
		optionsMenu = optionsMenu.GetComponent<Canvas> ();
		creditsMenu = creditsMenu.GetComponent<Canvas> ();
		exitMenu = exitMenu.GetComponent<Canvas> ();

		// Get all interactables:
		playButton = playButton.GetComponent<Button> ();
		optionsButton = optionsButton.GetComponent<Button> ();
		creditsButton = creditsButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();

		mainMenu.enabled = true;
	}

	public void Init () {
		mainMenu.enabled = true;

		playMenu.enabled = false;
		optionsMenu.enabled = false;
		creditsMenu.enabled = false;
		exitMenu.enabled = false;

		playButton.enabled = true;
		optionsButton.enabled = true;
		creditsButton.enabled = true;
		exitButton.enabled = true;
	}

	void Update() {
		// Nothing
	}
		
	public void PlayPress() {
		// Application.LoadLevel(1);
	}

	public void OptionsPress() {
		mainMenu.enabled = false;

		optionsMenu.GetComponent<OptionsScript> ().Init ();
	}

	public void CreditsPress() {
		mainMenu.enabled = false;

		creditsMenu.GetComponent<CreditsScript> ().Init ();
	}
	
	public void ExitPress() {
		playButton.enabled = false;
		optionsButton.enabled = false;
		creditsButton.enabled = false;
		exitButton.enabled = false;

		exitMenu.GetComponent<ExitScript> ().Init ();
	}
}
