using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	Transform camera;

	public float horizontalSensitivity;
	public float verticalSensitivity;
	public float zoomSensitivity;

	void Start () {
		camera = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Vertical") > 0f) {
			camera.position = new Vector3(camera.position.x, camera.position.y, camera.position.z+verticalSensitivity);
		}

		if (Input.GetAxis ("Vertical") < 0f) {
			camera.position = new Vector3(camera.position.x, camera.position.y, camera.position.z-verticalSensitivity);
		}

		if (Input.GetAxis ("Horizontal") > 0f) {
			camera.position = new Vector3(camera.position.x+horizontalSensitivity, camera.position.y, camera.position.z);
		}

		if (Input.GetAxis ("Horizontal") < 0f) {
			camera.position = new Vector3(camera.position.x-horizontalSensitivity, camera.position.y, camera.position.z);
		}

		float yNew = camera.position.y - zoomSensitivity * Input.GetAxis ("Mouse ScrollWheel")* Mathf.Sin (camera.rotation.eulerAngles.x * 2 * Mathf.PI / 360);
		float zNew = camera.position.z - zoomSensitivity * Input.GetAxis ("Mouse ScrollWheel")* Mathf.Cos (camera.rotation.eulerAngles.x * 2 * Mathf.PI / 360);

		camera.position = new Vector3 (camera.position.x, yNew, zNew);
	}
}
