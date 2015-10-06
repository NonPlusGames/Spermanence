using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Rigidbody rbody;
	Vector3 inputVector;
	public float moveSpeed=5;
	public Transform myCamera;
	bool miniGame=false;
	
	// Use this for initialization
	void Start () {
		rbody=GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame for input and graphics
	void Update () {
		//float jump=Input.GetButtonDown ("Jump") ? 1f : 0f;
		float mouseX=Input.GetAxis("Mouse X");
		float mouseY=Input.GetAxis("Mouse Y");
		if(miniGame==false)
		{
			inputVector=new Vector3(Input.GetAxis("Vertical"), 0,-Input.GetAxis("Horizontal") );
			Debug.Log("input: "+inputVector);
			transform.Rotate(0f,mouseX,-mouseY,Space.World);
		}
		if(miniGame==true)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				transform.position+=new Vector3(-.3f,0f,0f);
			}
		}
		myCamera.Rotate (0f,0f,0f);
		myCamera.transform.position=transform.position+ new Vector3(5f,2f,0f);
	}
	
	//for physics
	void FixedUpdate(){
		if(miniGame==false)
		{
			Debug.Log("velocity: "+rbody.velocity);
			//float yVelocity=rbody.velocity.y;
			rbody.velocity=-transform.TransformDirection (inputVector)*moveSpeed;
			//rbody.velocity+=new Vector3(0f,yVelocity,0f);
		}
		
	}

	public void SetMiniGame()
	{
		miniGame=true;
		rbody.isKinematic=true;
	}
}
