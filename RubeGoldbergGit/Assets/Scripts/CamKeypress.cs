using UnityEngine;
using System.Collections;

public class CamKeypress : MonoBehaviour {

	public float speed = 10;
	public float camRot = 0;
	public float rotRate = 90;
	
	// Use this for initialization
	void Start () {

		transform.rotation = Quaternion.AngleAxis(camRot, Vector3.up);

	
	}
	
	// Update is called once per frame
	void Update () {

		//Rotation Controls
		if (Input.GetKeyDown(KeyCode.A)){
			//transform.Rotate(Vector3.up * speed * Time.deltaTime);
			camRot += rotRate;
			transform.rotation = Quaternion.AngleAxis(camRot, Vector3.up);

		}
		
		if (Input.GetKeyDown(KeyCode.D)){
			//transform.Rotate(-Vector3.up * speed * Time.deltaTime);
			camRot -= rotRate;
			transform.rotation = Quaternion.AngleAxis(camRot, Vector3.up);
		}


		
	}
}
