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
	public Canvas exitMenu;
	public Canvas creditsMenu;

	// Interactables:
	public Button startButton;
	public Button optionsButton;
	public Button creditsButton;
	public Button exitButton;

	void Start () {
		// Get all menu screens:
		mainMenu = mainMenu.GetComponent<Canvas> ();
		exitMenu = exitMenu.GetComponent<Canvas> ();
		creditsMenu = creditsMenu.GetComponent<Canvas> ();

		// Get all interactables:
		startButton = startButton.GetComponent<Button> ();
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

		startButton.enabled = true;
		optionsButton.enabled = true;
		creditsButton.enabled = true;
		exitButton.enabled = true;
	}

	void Update() {
		/*if (exitMenu.enabled) {
			if (Input.GetMouseButtonDown (0)) {
				if (!exitScreen.rectTransform.rect.Contains(Input.mousePosition - mainCamera.position)) {
					NoPress ();
				}
			}
		} */
	}
		
	public void PlayPress() {
		// Application.LoadLevel(1);
	}

	public void OptionsPress() {

	}

	public void CreditsPress() {
		creditsMenu.GetComponent<CreditsScript> ().Init ();
	}
	
	public void ExitPress() {
		exitMenu.GetComponent<ExitScript> ().Init ();

		startButton.enabled = false;
		optionsButton.enabled = false;
		creditsButton.enabled = false;
		exitButton.enabled = false;
	}
}
