using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControlsScript : MonoBehaviour {

	// Current Menu:
	public Canvas controlsMenu;

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
		controlsMenu = controlsMenu.GetComponent<Canvas> ();
		optionsMenu = optionsMenu.GetComponent<Canvas> ();

		// Get all interactables
		backButton = backButton.GetComponent<Button> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();

		controlsMenu.enabled = false;
	}

	public void Init () {
		controlsMenu.enabled = true;
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		controlsMenu.enabled = false;
		optionsMenu.GetComponent<OptionsScript> ().Init ();
	}
}
