using UnityEngine;
using System.Collections;

public class TowersManager : MonoBehaviour {

	Canvas towersOn;
	Canvas towersOff;

	public GameObject selectedTower;


	void Start () {
		
		towersOn = GameObject.Find ("TowersOn").GetComponent<Canvas> ();
		towersOff = GameObject.Find ("TowersOff").GetComponent<Canvas> ();

		towersOff.enabled = false;
		towersOn.enabled = true;
	}

	void Update () {
		
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
