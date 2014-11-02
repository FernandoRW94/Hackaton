using UnityEngine;
using System.Collections;

public class BackGroundScript : MonoBehaviour {
	public Material wins;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerScript.lives < 1) {	
			this.gameObject.renderer.material = wins;
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
			{
				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);		
				if (Physics.Raycast (ray, out hit)) {
					if (hit.transform.tag == "next") {

						Application.LoadLevel(6);
					}
				}
			}
		}
	}
}
