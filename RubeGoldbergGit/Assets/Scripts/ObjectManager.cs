using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour {

	public GameObject[] objects;
	private ObjectPlacement objectPlacement;

	// Use this for initialization
	void Start () {
		objectPlacement = GetComponent<ObjectPlacement>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		for( int i = 0; i < objects.Length; i ++){
			if(GUI.Button(new Rect(Screen.width/20, Screen.height/15 + Screen.height/12 * i, 100, 30 ), objects[i].name)){
				objectPlacement.SetItem(objects[i]);
			}
		}
	}
}
