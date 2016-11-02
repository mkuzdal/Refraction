using UnityEngine;
using UnityEngine.UI;
using System.Collections;

class MenuManager : MonoBehaviour {

	public static GameObject mainMenu;
	public static GameObject optionsMenu;
	public static GameObject creditsMenu;
	public static GameObject exitMenu;
	public static GameObject audioMenu;
	public static GameObject graphicsMenu;
	public static GameObject controlsMenu;
	public static GameObject menuUnderlay;

	public enum Menus {
		MainMenu, 		// 0
		OptionsMenu, 	// 1
		CreditsMenu, 	// 2
		ExitMenu, 		// 3
		AudioMenu, 		// 4
		GraphicsMenu, 	// 5
		ControlsMenu	// 6
	};

	void Start () {
		// Get all menus:
		mainMenu = GameObject.Find("MainMenu");
		optionsMenu = GameObject.Find("OptionsMenu");
		creditsMenu = GameObject.Find("CreditsMenu");
		exitMenu = GameObject.Find("ExitMenu");
		audioMenu = GameObject.Find("AudioMenu");
		graphicsMenu = GameObject.Find("GraphicsMenu");
		controlsMenu = GameObject.Find("ControlsMenu");
		menuUnderlay = GameObject.Find ("MenuUnderlay");

		// Disable all menus except for the original:
		mainMenu.GetComponent<Canvas> ().enabled = true;
		optionsMenu.GetComponent<Canvas> ().enabled = false;
		creditsMenu.GetComponent<Canvas> ().enabled = false;
		exitMenu.GetComponent<Canvas> ().enabled = false;
		audioMenu.GetComponent<Canvas> ().enabled = false;
		graphicsMenu.GetComponent<Canvas> ().enabled = false;
		controlsMenu.GetComponent<Canvas> ().enabled = false;
		menuUnderlay.GetComponent<Canvas> ().enabled = false;

	}

	public static void ChangeMenu (int menuA, int menuB, bool isAPopUp, bool isBPopUp) {

		switch (menuA) {

		case (int)Menus.MainMenu:
			if (isBPopUp) {
				mainMenu.GetComponent<MenuScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				mainMenu.GetComponent<Canvas> ().enabled = false;
			break;

		case (int)Menus.OptionsMenu:
			
			if (isBPopUp) {
				optionsMenu.GetComponent<OptionsScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				optionsMenu.GetComponent<Canvas> ().enabled = false;
			break;

		case (int)Menus.CreditsMenu:
			if (isBPopUp) {
				creditsMenu.GetComponent<CreditsScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				creditsMenu.GetComponent<Canvas> ().enabled = false;
			break;

		case (int)Menus.ExitMenu:
			if (isBPopUp) {
				exitMenu.GetComponent<ExitScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				exitMenu.GetComponent<Canvas> ().enabled = false;
			break;

		case (int)Menus.AudioMenu:
			if (isBPopUp) {
				audioMenu.GetComponent<AudioScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				audioMenu.GetComponent<Canvas> ().enabled = false;
			break;

		case (int)Menus.GraphicsMenu:
			if (isBPopUp) {
				graphicsMenu.GetComponent<GraphicsScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				graphicsMenu.GetComponent<Canvas> ().enabled = false;
			break;

		case (int)Menus.ControlsMenu:
			if (isBPopUp) {
				controlsMenu.GetComponent<ControlsScript> ().disableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = true;
			} else
				controlsMenu.GetComponent<Canvas> ().enabled = false;
			break;

		default:
			Debug.Log ("ERROR WHEN TRANSITIONING BETWEEN MENUS");
			break;
		}


		switch (menuB) {

		case (int)Menus.MainMenu:
			if (isAPopUp) {
				mainMenu.GetComponent<MenuScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				mainMenu.GetComponent<Canvas> ().enabled = true;
			break;

		case (int)Menus.OptionsMenu:
			if (isAPopUp) {
				optionsMenu.GetComponent<OptionsScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				optionsMenu.GetComponent<Canvas> ().enabled = true;
			break;

		case (int)Menus.CreditsMenu:
			if (isAPopUp) {
				creditsMenu.GetComponent<CreditsScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				creditsMenu.GetComponent<Canvas> ().enabled = true;
			break;

		case (int)Menus.ExitMenu:
			if (isAPopUp) {
				exitMenu.GetComponent<ExitScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				exitMenu.GetComponent<Canvas> ().enabled = true;
			break;

		case (int)Menus.AudioMenu:
			if (isAPopUp) {
				audioMenu.GetComponent<AudioScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				audioMenu.GetComponent<Canvas> ().enabled = true;
			break;

		case (int)Menus.GraphicsMenu:
			if (isAPopUp) {
				graphicsMenu.GetComponent<GraphicsScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				graphicsMenu.GetComponent<Canvas> ().enabled = true;
			break;

		case (int)Menus.ControlsMenu:
			if (isAPopUp) {
				controlsMenu.GetComponent<ControlsScript> ().enableButtons ();
				menuUnderlay.GetComponent<Canvas> ().enabled = false;
			} else
				controlsMenu.GetComponent<Canvas> ().enabled = true;
			break;

		default:
			Debug.Log ("ERROR WHEN TRANSITIONING BETWEEN MENUS");
			break;
		}
	}
}
