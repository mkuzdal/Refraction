using UnityEngine;
using System.Collections;

public class TowerPad : MonoBehaviour {

	UIManager UI;
	GameObject tower;

	public Material placement;
	public Material actual;

	bool placed;

	void Start() {
		UI = GameObject.FindObjectOfType<UIManager> ();
		placed = false;
	}

	void OnMouseEnter() {

		if (UI.selectedTower != null) {
			// We have a selected tower
			tower = (GameObject)Instantiate (Resources.Load (UI.selectedTower), gameObject.transform.position, gameObject.transform.rotation);

			foreach(Renderer r in tower.GetComponentsInChildren<Renderer> ()) {
				r.material = placement;
			} 
			tower.GetComponentInChildren<Light> ().enabled = false;
		}
	}

	void OnMouseDrag() {
		if (tower.name == "LaserTower") {

			Vector3 dir = Input.mousePosition - tower.transform.position;
			Quaternion lookRot = Quaternion.LookRotation (dir);
			Transform turretTransform = transform.Find ("LaserTurret");
			turretTransform.rotation = Quaternion.Euler (0, lookRot.y, 0);
		}
	}

	void OnMouseUp() {
		foreach (Renderer r in tower.GetComponentsInChildren<Renderer> ()) {
			r.material = actual;
		}
		tower.GetComponentInChildren<Light> ().enabled = true;
		placed = true;
	}

	void OnMouseExit() {
		if (!placed) {
			Destroy (tower);
		} 

		placed = false;
	}
		
}
