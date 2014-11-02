using UnityEngine;
using System.Collections;

public class IniciarScript : MonoBehaviour {

	public Material Startclick;

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

				if (hit.transform.tag == "iniciar") {
					hit.transform.gameObject.renderer.material = Startclick;
					Application.LoadLevel(2);
				}
			}
		}
	}
}
