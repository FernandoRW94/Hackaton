﻿using UnityEngine;
using System.Collections;

public class AboboraGiro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject.FindGameObjectWithTag ("Player").transform.Rotate (0, 1, 0);
	}
}
