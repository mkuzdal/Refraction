using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GraphicsScript : MonoBehaviour {
	/**
		Current Menu:
		graphicsMenu

		Super Menus:
		optionsMenu

		Sub Menus:
		NONE
	**/

	// Interactables:
	public Text titleText;
	public Text backButton;

	public Image screen;
	public Transform camera;

	void Start () {
		// Get all interactables
		titleText = titleText.GetComponent<Text> ();
		backButton = backButton.GetComponent<Text> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();
	}

	void Update () {
		// Nothing
	}

	public void BackPress () {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.GraphicsMenu, (int)MenuManager.Menus.OptionsMenu, false, false);
	}

	public void enableButtons() {
		/*titleText.enabled = true;
		backButton.enabled = true;*/
		backButton.gameObject.GetComponent<Button> ().enabled = true;
	}

	public void disableButtons() {
		/*titleText.enabled = false;
		backButton.enabled = false;*/
		backButton.gameObject.GetComponent<Button> ().enabled = false;
	}
}
