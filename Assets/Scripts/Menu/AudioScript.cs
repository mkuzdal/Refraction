using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioScript : MonoBehaviour {

	// Current Menu:
	public Canvas audioMenu;

	// Super Menus:
	public Canvas optionsMenu;

	// Sub Menus:
	// NONE

	// Interactables:
	public Button backButton;

	public Image screen;
	public Transform camera;

	void Start () {
		// Get all menu screens
		audioMenu = audioMenu.GetComponent<Canvas> ();
		optionsMenu = optionsMenu.GetComponent<Canvas> ();

		// Get all interactables
		backButton = backButton.GetComponent<Button> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();

		audioMenu.enabled = false;
	}

	public void Init () {
		audioMenu.enabled = true;
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		audioMenu.enabled = false;
		optionsMenu.GetComponent<OptionsScript> ().Init ();
	}
}
