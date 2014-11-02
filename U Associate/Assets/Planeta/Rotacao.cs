
using UnityEngine;
using System.Collections;

public class Rotacao : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
			
						transform.Rotate (0, -4.5f * Time.deltaTime, 0);
				
		}
}