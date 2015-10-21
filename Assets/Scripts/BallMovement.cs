using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	Vector3 inputVector;
	Vector3 inputVector2;
	Rigidbody rbody;
	public GameObject egg;

	void Start()
	{
		rbody =GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
	
		inputVector=(egg.transform.position-transform.position);
		inputVector2=(Camera.main.transform.position-transform.position);
	}
	
	void FixedUpdate()
	{
		//Normalize, standardizes a vector to length 1
		
		rbody.GetComponent<Rigidbody>().velocity +=Vector3.Normalize(inputVector)*1.0f;
		rbody.GetComponent<Rigidbody>().velocity +=Vector3.Normalize(inputVector2)*1.2f;
	}
}
