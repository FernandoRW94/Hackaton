using UnityEngine;
using System.Collections;

public class CorAbobora : MonoBehaviour {

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
				if (hit.transform.tag == "laranja") {
					Application.LoadLevel(4);
				}else if(hit.transform.tag == "verde"){
					GameObject.FindGameObjectWithTag("verde").audio.Play();
				}
			}
		}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}

	}

}
