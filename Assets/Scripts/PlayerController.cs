using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	Rigidbody rbody;
	public Transform tail;
	public Transform sphere;
	Vector3 inputVector;
	public float moveSpeed=5;
	public Transform myCamera;
	public float dash;
	public float tailSpin;
	public float xPos;
	public float yPos;
	public float zPos;
	public GameObject egg;
	public float smoothTime = 0.1F;
	public float newPosx;
	public float newPosy;
	private Vector3 velocity = Vector3.zero;
	public Transform goal;
	public GameObject embryo;
	public float theTimer;
	public float startTime;
	public Text text;
	
	bool miniGame=false;
	
	// Use this for initialization
	void Start () {
		rbody=GetComponent<Rigidbody>();
		xPos=5f;
		yPos=2f;
		zPos=0f;
		theTimer=20.0f;
	}
	
	// Update is called once per frame for input and graphics
	void Update () {
		tail.Rotate(Vector3.up*tailSpin);

		float mouseX=Input.GetAxis("Mouse X");
		float mouseY=Input.GetAxis("Mouse Y");
		if(miniGame==false)
		{


			transform.Rotate(0f,mouseX,-mouseY);
			if(Input.GetKey(KeyCode.A))
			{
				myCamera.transform.RotateAround(transform.position, Vector3.up, 5f);
				
			}
			if(Input.GetKey(KeyCode.D))
			{
				myCamera.transform.RotateAround(transform.position, Vector3.up, -5f);
				
			}

		}
		inputVector=(egg.transform.position-transform.position);
		if(miniGame==true)
		{
			//theTimer -= Time.deltaTime;
			//text.text+="  "+theTimer;
			if(Input.GetKey(KeyCode.A))
			{
				myCamera.transform.RotateAround(transform.position, Vector3.up, 5f);
				
			}
			if(Input.GetKey(KeyCode.D))
			{
				myCamera.transform.RotateAround(transform.position, Vector3.up, -5f);
				
			}
			//myCamera.transform.position=new Vector3(3.5f, 1f, 3.5f); 
			if(Input.GetKeyDown(KeyCode.Space))
			{
				transform.position=Vector3.SmoothDamp(transform.position,goal.transform.position, ref velocity, smoothTime);
			}
			if(Vector3.Distance(transform.position,goal.position)<10.0f)
			{
				Instantiate (embryo, transform.position+new Vector3(-20f,-28f, 0f), Quaternion.identity);
				Destroy(gameObject);
			}
		}

	}
	
	//for physics
	void FixedUpdate(){
		if(miniGame==false)
		{


			if(Input.GetKeyDown(KeyCode.Space))
			{
				rbody.velocity=rbody.velocity*.5f;
				rbody.AddForce(-transform.right*dash, ForceMode.Impulse);
				tailSpin+=20;
			}
			if(tailSpin>=30)
				tailSpin-=1;
		}
		
	}

	public void SetMiniGame()
	{
		miniGame=true;
		rbody.isKinematic=true;
	}
}
