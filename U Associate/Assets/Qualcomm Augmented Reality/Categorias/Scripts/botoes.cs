using UnityEngine;
using System.Collections;

public class botoes : MonoBehaviour {

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
				if (hit.transform.tag == "alimentacao") {
					Application.LoadLevel(2);
				}else if(hit.transform.tag == "animais"){
					Application.LoadLevel(6);
				}else if(hit.transform.tag == "ciencia"){
					Application.LoadLevel(10);
				}
			}

		}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}

	}
}
