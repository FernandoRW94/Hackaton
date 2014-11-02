using UnityEngine;
using System.Collections;

public class PlayerPosScript : MonoBehaviour {


	float amtToMove;
	float amtToMove2;

	public Material leftClick;
	public Material rightClick;
	public Material leftNormal;
	public Material rightNormal;

	// Use this for initialization
	void Start () {
		amtToMove = 1 * 20 * Time.deltaTime;
		amtToMove2 = -amtToMove;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit))
			{
				if (hit.transform.tag == "BotaoLeft") 
				{
					hit.transform.gameObject.renderer.material = leftClick;
					if(transform.position.x >= -8.1f)
						transform.Translate (Vector3.right * amtToMove2);
					
				} else if (hit.transform.tag == "BotaoRight") 
				{
					hit.transform.gameObject.renderer.material = rightClick;
					if(transform.position.x <= 8.1f)
						transform.Translate (Vector3.right * amtToMove);
					
					
				}
			}
		}
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit))
			{
				if (hit.transform.tag == "BotaoLeft") 
				{
					hit.transform.gameObject.renderer.material = leftClick;
					if(transform.position.x >= -8.1f)
						transform.Translate (Vector3.right * amtToMove2);
					
				} else if (hit.transform.tag == "BotaoRight") 
				{
					hit.transform.gameObject.renderer.material = rightClick;
					if(transform.position.x <= 8.1f)
						transform.Translate (Vector3.right * amtToMove);
					
					
				}
			}
		}
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended)
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit))
			{
				if (hit.transform.tag == "BotaoLeft") 
				{
					hit.transform.gameObject.renderer.material = leftNormal;
					
				} else if (hit.transform.tag == "BotaoRight") 
				{
					hit.transform.gameObject.renderer.material = rightNormal;								
				}
			}
		}}
		}
		


		



