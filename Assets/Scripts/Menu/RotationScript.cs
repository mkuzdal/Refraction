﻿using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {

	public float rotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, rotationSpeed, 0));	
	}
}
