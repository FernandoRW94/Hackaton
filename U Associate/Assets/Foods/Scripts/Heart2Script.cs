using UnityEngine;
using System.Collections;

public class Heart2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.lives < 2) 
		{
			Destroy(this.gameObject);
		}
	}
}
