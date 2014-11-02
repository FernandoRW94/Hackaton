using UnityEngine;
using System.Collections;

public class FoodScript : MonoBehaviour {

	// Use this for initialization

	public float minSpeed;
	public float maxSpeed;
	public float currentSpeed;
	private float x, y, z;
	private float minRotateSpeed = 60f;
	private float maxRotateSpeed = 100f;
	private float currentRotateSpeed;
	
	// Use this for initialization
	void Start () {
		SetPositionAndSpeed ();//chama metodo para setar a posicao e a velocidade
	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = currentRotateSpeed * Time.deltaTime;
		transform.Rotate (new Vector3 (-1, -1.5f, 0) * rotationSpeed);
		
		float amtToMove = currentSpeed * Time.deltaTime;
		transform.Translate (Vector3.back * amtToMove,Space.World);
		if (transform.position.z <= -17)
		{
			PlayerScript.missed ++;
			Destroy(this.gameObject);
		}

		
	}
	

public void SetPositionAndSpeed(){
		currentRotateSpeed = Random.Range (minRotateSpeed, maxRotateSpeed);
		currentSpeed = Random.RandomRange (minSpeed, maxSpeed);//randomiza velocidade entre a minima e maxima
		x = Random.RandomRange (-7.7f, 7.7f);
		y = 3f;
		z = 12.3f;
		transform.position = new Vector3(x, y, z);//seta a posicao do objeto com base nas variaveis ja setadas

	}
}







