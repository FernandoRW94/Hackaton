using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public static int missed = 1;
	public static int lives = 3;
	public GameObject good_2Prefab;
	public GameObject bad_2Prefab;
	public GameObject parent;


	int x;
	public TextMesh score;
	public static int intScore = 0;
	
	GameObject go;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {



		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}

		if (lives == 0) 
		{
			score.transform.position= new Vector3(0.1674f,-0.02f,-0.229f);
			Destroy(this.gameObject);
		}

		if (missed != 0 && lives > 0) 
		
		{
			x = Random.RandomRange (1, 3);
			print("X: "+x);
			print ("missed: "+missed);
			if(x==1){

				go = (GameObject)Instantiate(good_2Prefab);
				go.transform.parent= parent.transform;
			}
			if(x==2){
				go = (GameObject)Instantiate(bad_2Prefab);
				go.transform.parent = parent.transform;
			}	
			missed--;
		}

	}


	


	void OnTriggerEnter(Collider otherObject)
	{

		if (otherObject.tag == "good")
		{

			Destroy(otherObject.gameObject);
			intScore+=10;
			if(intScore == 50)
				missed++;
			if(intScore == 100)
				missed++;
			if(intScore == 150)
				missed++;
			score.text = intScore.ToString();
			print ("missed: "+missed);
		}
		if (otherObject.tag == "bad")
		{

			Destroy(otherObject.gameObject);
			lives--;
			missed++;

		}
	}
}
