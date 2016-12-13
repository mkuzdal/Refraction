using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	GameObject path;

	Transform targetPathNode;
	int pathNodeIndex = 0;

	public float speed = 50f;
	public float health = 1;


	void Start () {
		
		path = GameObject.Find ("Path1");
	}
	
	void Update () {

		// We don't have a path to follow
		if (targetPathNode == null) {
			GetNextPathNode ();
			if (targetPathNode == null) {
				// No more path!
				ReachedGoal ();
			}
		}

		// We have our path, now we get the direction to travel
		Vector3 direction = targetPathNode.position - this.transform.localPosition;

		float distThisFrame = speed * Time.deltaTime;

		if (direction.magnitude <= distThisFrame) {
			// We reached the node!
			targetPathNode = null;
		} else {
			// Move towards the node
			Debug.Log (targetPathNode.position);
			transform.Translate (direction.normalized * distThisFrame, Space.World);
			Quaternion targetRotation = Quaternion.LookRotation (direction);
			this.transform.rotation = Quaternion.Lerp (this.transform.rotation, targetRotation, 2*Time.deltaTime);
		}
	}



	void GetNextPathNode () {
		if (pathNodeIndex < path.transform.childCount) {
			targetPathNode = path.transform.GetChild (pathNodeIndex);	
			pathNodeIndex++;
		}
	}

	void ReachedGoal () {
		Destroy (gameObject);
	}
}
