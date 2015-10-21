using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	

	public GameObject ball;
	public int counter;
	
	void Start()
	{
		int i=0;
		while(i<300)
		{
			Instantiate (ball, transform.position, Quaternion.identity);
			i++;
		}
		counter=0;		
		
	}
	
	// Update is called once per frame
	void Update () {
	
				
	
	}
}
