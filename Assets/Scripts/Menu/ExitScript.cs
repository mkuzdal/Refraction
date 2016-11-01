using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitScript : MonoBehaviour {
	
	// Current Menu:
	public Canvas exitMenu;

	// Super Menus:
	public Canvas mainMenu;

	// Sub Menus:
	// NONE

	// Interactables:
	public Button buttonYes;
	public Button buttonNo;

	public Image screen;
	public Transform camera;

	void Start () {
		// Get all menu screens
		exitMenu = exitMenu.GetComponent<Canvas> ();
		mainMenu = mainMenu.GetComponent<Canvas> ();

		// Get all interactables
		buttonYes = buttonYes.GetComponent<Button> ();
		buttonNo = buttonNo.GetComponent<Button> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();

		exitMenu.enabled = false;
	}

	public void Init () {
		exitMenu.enabled = true;
	}

	void Update () {
		if (exitMenu.enabled && Input.GetMouseButtonDown (0)) {
			if (!screen.rectTransform.rect.Contains (Input.mousePosition - camera.position))
				NoPress ();
		}
	}
	
	public void YesPress () {
		Application.Quit ();
		Debug.Log ("QUIT");
	}

	public void NoPress () {
		exitMenu.enabled = false;
		mainMenu.GetComponent<MenuScript> ().Init ();
	}
}
