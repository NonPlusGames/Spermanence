using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public Transform sperm;
	public GameObject newCamera;
	// Use this for initialization
	void Start () {
		newCamera.GetComponent<Camera>().enabled=false;
	}
	
	// Update is called once per frame
	void Update () {

		if(!(sperm==null))
			transform.position=sperm.position;
		if(sperm==null)
			newCamera.GetComponent<Camera>().enabled=true;
	}
}
