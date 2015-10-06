using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	Vector3 inputVector;
	Rigidbody rbody;

	void Start()
	{
		rbody =GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
	
		inputVector=(Camera.main.transform.position+new Vector3(-3f,0f,0f))-transform.position;
		
	}
	
	void FixedUpdate()
	{
		//Normalize, standardizes a vector to length 1
		
		rbody.GetComponent<Rigidbody>().velocity +=Vector3.Normalize(inputVector)*.1f;
	}
}
