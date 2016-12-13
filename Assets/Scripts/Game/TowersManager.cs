using UnityEngine;
using System.Collections;

public class TowersManager : MonoBehaviour {

	Canvas towersOn;
	Canvas towersOff;

	int buttonClicked = 0;

	void Start () {
		
		towersOn = GameObject.Find ("TowersOn").GetComponent<Canvas> ();
		towersOff = GameObject.Find ("TowersOff").GetComponent<Canvas> ();

		towersOff.enabled = false;
		towersOn.enabled = true;
	}

	void Update () {


		if (buttonClicked != 0) {
			// We have a tower to place

		}
	}

	public void ToggleScreens () {
		
		if (towersOn.enabled == false) {
			towersOn.enabled = true;
			towersOff.enabled = false;
		} else {
			towersOff.enabled = true;
			towersOn.enabled = false;
		}
	}

	public void ClickedTower1 () {
		
	}
}
