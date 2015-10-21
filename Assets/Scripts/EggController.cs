using UnityEngine;
using System.Collections;

public class EggController : MonoBehaviour {
	public Rigidbody sperm;
	public GameObject embryo;
	public Canvas text;
	public Transform goal;
	// Use this for initialization
	void Start () {
		text.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider activator)
	{
		if(activator.GetComponent<Collider>().tag=="Player")
		{
			//text.enabled=true;
			activator.GetComponent<PlayerController>().SetMiniGame();

		}
	}
}
