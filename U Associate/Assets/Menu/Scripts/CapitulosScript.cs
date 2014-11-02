using UnityEngine;
using System.Collections;

public class CapitulosScript : MonoBehaviour {

	public Material capclick;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);		
			if (Physics.Raycast (ray, out hit)) {

				if (hit.transform.tag == "capitulos") {
					hit.transform.gameObject.renderer.material = capclick;
					Application.LoadLevel(5);
				}
			}
		}
	}
}
