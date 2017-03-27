using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	Canvas towersOn;
	Canvas towersOff;

	public string selectedTower;

	public enum towerType { 
		LaserTower,    // 0
		ConcaveTower,  // 1
		ConvexTower,   // 2
		CrystalTower,  // 3
		DiscoTower,    // 4
		BeaconTower,   // 5
		SpotlightTower // 6
	};

	void Start () {

		selectedTower = null;

		towersOn = GameObject.Find ("TowersOn").GetComponent<Canvas> ();
		towersOff = GameObject.Find ("TowersOff").GetComponent<Canvas> ();

		towersOff.enabled = false;
		towersOn.enabled = true;
	}

	void Update () {
		
		if (selectedTower != null) {
			if (Input.GetMouseButtonUp(1)) {
				Debug.Log ("RIGHT CLICK. DESELECTED TOWER");
				selectedTower = null;
			}
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

	public void ClickedTower (int n) {
		switch(n)
		{
		case (int)UIManager.towerType.LaserTower:
			selectedTower = "LaserTower";
			Debug.Log ("CLICKED");
			break;
		case (int)UIManager.towerType.ConcaveTower:
			selectedTower = "ConcaveTower";
			break;
		case (int)UIManager.towerType.ConvexTower:
			selectedTower = "ConvexTower";
			break;
		case (int)UIManager.towerType.CrystalTower:
			selectedTower = "CrystalTower";
			break;
		case (int)UIManager.towerType.DiscoTower:
			selectedTower = "DiscoTower";
			break;
		case (int)UIManager.towerType.BeaconTower:
			selectedTower = "BeaconTower";
			break;
		case (int)UIManager.towerType.SpotlightTower:
			selectedTower = "SpotlightTower";
			break;
		}
	}
}
