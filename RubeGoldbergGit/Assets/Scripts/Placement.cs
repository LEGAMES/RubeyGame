using UnityEngine;
using System.Collections;

public class Placement : MonoBehaviour {

    bool placed = false;
    int yPos = 0;

    Color originalColor;
    public int collisions = 0;

	void Start () {
        originalColor = transform.GetComponent<Renderer>().material.color;
        //transform.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0.5f);
	}

    public bool Placed()
    {
        return placed;
    }
	
	void Update () {
	    if(!placed)
        {
            if (Input.GetMouseButtonDown(0) && collisions == 0)
            {
                placed = true;
                transform.GetComponent<Renderer>().material.color = originalColor;
            }
            if(Input.GetMouseButtonDown(1))
            {
                Destroy(this.gameObject);
            }

            if(Input.GetKeyDown(KeyCode.W))
            {
                if(yPos < 8)
                    yPos++;
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                if(yPos > 0)
                    yPos--;
            }

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //if (hit.transform.tag == "Ground")
                //{
                    transform.position = new Vector3((int)hit.point.x, yPos, (int)hit.point.z);
                //}
            }

            float mouseWheel = Input.GetAxis("Mouse ScrollWheel");

			if(Input.GetKeyDown(KeyCode.Q))
            {
                transform.Rotate(new Vector3(0, 90, 0));
            }
			if(Input.GetKeyDown(KeyCode.E))
            {
                transform.Rotate(new Vector3(0, -90, 0));
            }
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag != "Ground")
            collisions++;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag != "Ground")
            collisions--;
    }
}
