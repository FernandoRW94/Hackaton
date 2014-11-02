using UnityEngine;
using System.Collections;

public class Heart3Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (PlayerScript.lives < 3) 
		{
			Destroy(this.gameObject);
		}

	}
}
