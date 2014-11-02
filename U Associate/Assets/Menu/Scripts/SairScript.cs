using UnityEngine;
using System.Collections;

public class SairScript : MonoBehaviour {
	
	public Material click;

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
				if (hit.transform.tag == "sair") {
					hit.transform.gameObject.renderer.material = click;
					Application.Quit();
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
