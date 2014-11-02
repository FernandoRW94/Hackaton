using UnityEngine;
using System.Collections;

public class CorLimao : MonoBehaviour {

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
				if (hit.transform.tag == "verde") {
					Application.LoadLevel(3);
				}else if(hit.transform.tag == "laranja"){
					GameObject.FindGameObjectWithTag("laranja").audio.Play();
				}
			}
	}
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}
}
}