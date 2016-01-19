using UnityEngine;
using System.Collections;

public class ObjectPlacement : MonoBehaviour {

	public float speed;

	private PlaceableObject placeableObject;
	private Transform currentObject;
	private bool hasPlaced;
	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
		if(currentObject != null && !hasPlaced){
			Vector3 m = Input.mousePosition;
			m = new Vector3(m.x,m.y, transform.position.y);
			Vector3 p = GetComponent<Camera>().ScreenToWorldPoint(m);
			currentObject.position = new Vector3(p.x,p.y,p.z);
			currentObject.Rotate(Vector3.up * speed * Time.deltaTime);﻿
			
			//Placenment
			if(Input.GetMouseButtonDown(0)){
				if(IsLegalPosition()){
					hasPlaced = true;
				}
			}
		} 	
	}

	bool IsLegalPosition(){
		if(placeableObject.colliders.Count > 0){
			return false;
		}
		return true;
	}

	public void SetItem(GameObject b){
		hasPlaced = false;
		currentObject = ((GameObject)Instantiate(b)).transform;
		placeableObject = currentObject.GetComponent<PlaceableObject>();
	}
}
