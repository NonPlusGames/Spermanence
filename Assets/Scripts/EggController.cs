using UnityEngine;
using System.Collections;

public class EggController : MonoBehaviour {
	public Rigidbody sperm;
	public Canvas text;
	// Use this for initialization
	void Start () {
		text.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider activator)
	{
		if(activator.GetComponent<Collider>().name=="Player")
		{
			activator.GetComponent<PlayerController>().SetMiniGame();
			text.enabled=true;
		}
	}
}
