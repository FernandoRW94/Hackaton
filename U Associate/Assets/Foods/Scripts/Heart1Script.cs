using UnityEngine;
using System.Collections;

public class Heart1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.lives < 1) 
		{
			Destroy(this.gameObject);
		}
	}
}
