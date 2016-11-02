using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitScript : MonoBehaviour {
	/**
		Current Menu:
		exitMenu

		Super Menus:
		mainMenu

		Sub Menus:
		NONE
	**/

	// Interactables:
	public Text titleText;
	public Text buttonYes;
	public Text buttonNo;

	public Image screen;
	public Transform camera;

	void Start () {
		// Get all interactables
		titleText = titleText.GetComponent<Text> ();
		buttonYes = buttonYes.GetComponent<Text> ();
		buttonNo = buttonNo.GetComponent<Text> ();

		screen = screen.GetComponent<Image> ();
		camera = camera.GetComponent<Transform> ();
	}

	void Update () {
		if (MenuManager.exitMenu.GetComponent<Canvas> ().enabled && Input.GetMouseButtonDown (0)) {
			if (!screen.rectTransform.rect.Contains (Input.mousePosition - camera.position))
				NoPress ();
		}
	}
	
	public void YesPress () {
		Application.Quit ();
		Debug.Log ("QUIT");
	}

	public void NoPress () {
		MenuManager.ChangeMenu ((int)MenuManager.Menus.ExitMenu, (int)MenuManager.Menus.MainMenu, true, false);
	}

	public void enableButtons() {
		/*titleText.enabled = true;
		buttonYes.enabled = true;
		buttonNo.enabled = true;*/
		buttonYes.gameObject.GetComponent<Button> ().enabled = true;
		buttonNo.gameObject.GetComponent<Button> ().enabled = true;
	}

	public void disableButtons() {
		/*titleText.enabled = false;
		buttonYes.enabled = false;
		buttonNo.enabled = false;*/
		buttonYes.gameObject.GetComponent<Button> ().enabled = false;
		buttonNo.gameObject.GetComponent<Button> ().enabled = false;
	}
}
