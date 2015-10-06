using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	

	public GameObject ball;
	public int counter;
	
	void Start()
	{
		int i=0;
		while(i<10)
		{
			Instantiate (ball, new Vector3(-9f,5f,0), Quaternion.identity);
			i++;
		}
		counter=0;		
		
	}
	
	// Update is called once per frame
	void Update () {
		if(counter==25)
		{
			Instantiate (ball, new Vector3(-9f,5f,0), Quaternion.identity);
			counter=0;
		}
		counter++;
	
	}
}
