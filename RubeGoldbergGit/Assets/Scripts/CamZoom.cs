using UnityEngine;
using System.Collections;

public class CamZoom : MonoBehaviour {


	float cameraDistanceMax = 20f;
	float cameraDistanceMin = 5f;
	float cameraDistance = 10f;
	float scrollSpeed = 0.5f;

	public const int minZoom = 1;
	public const int maxZoom  = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		const int orthographicSizeMin = minZoom;
		const int orthographicSizeMax = maxZoom;
		
		
		if (Input.GetAxis("Mouse ScrollWheel") < 0) // forward
		{
			Camera.main.orthographicSize++;
		}
		if (Input.GetAxis("Mouse ScrollWheel") > 0) // back
		{
			Camera.main.orthographicSize--;
		}
		Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax );
		
	}
}
