using UnityEngine;
using System.Collections;

public class Lives0 : MonoBehaviour {

	int score;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.lives < 1){
			score = PlayerScript.intScore;
			Destroy(this.gameObject);
		}

	}
}
