using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GraphicsScript : MonoBehaviour {

	// Current Menu:
	public Canvas graphicsMenu;

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
		graphicsMenu = graphicsMenu.GetComponent<Canvas> ();
		optionsMenu = optionsMenu.GetComponent<Canvas> ();

		// Get all interactables
		backButton = backButton.GetComponent<Button> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();

		graphicsMenu.enabled = false;
	}

	public void Init () {
		graphicsMenu.enabled = true;
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		graphicsMenu.enabled = false;
		optionsMenu.GetComponent<OptionsScript> ().Init ();
	}
}
