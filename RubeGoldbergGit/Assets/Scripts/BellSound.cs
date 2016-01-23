using UnityEngine;
using System.Collections;

public class BellSound : MonoBehaviour {

	public AudioClip bell;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}

	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Ball")
		{
			GetComponent<AudioSource>().PlayOneShot(bell);
		}
		
	}
}
