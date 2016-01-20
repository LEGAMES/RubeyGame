using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject[] objects;
    public int buttonSize = 10;

    GameObject currentObject;

    bool settingUp = true;

    void Start()
    {
        //Time.timeScale = 0;
    }

    void OnGUI()
    {
        int initialX = 0;
        int initialY = 0;

        if(GUI.Button(new Rect(buttonSize+500, 500, buttonSize, buttonSize), "Play"))
        {
            StartStage();
        }

        foreach(GameObject go in objects)
        {
            if (GUI.Button(new Rect(initialX+200, initialY+200, buttonSize, buttonSize), go.name))
            {
                if (currentObject != null)
                {
                    if (!currentObject.GetComponent<Placement>().Placed())
                    {
                        Destroy(currentObject);
                    }
                    currentObject = (GameObject)Instantiate(go);
                }
                else
                {
                    currentObject = (GameObject)Instantiate(go);
                }
            }

            initialY += buttonSize;
        }
    }

    void StartStage()
    {
        //Time.timeScale = 1;
        GameObject[] allBalls = GameObject.FindGameObjectsWithTag("Ball");
        foreach(GameObject ball in allBalls)
        {
            ball.GetComponent<Rigidbody>().isKinematic = false;
            ball.GetComponent<Rigidbody>().useGravity = true;

            ball.GetComponent<LineRenderer>().enabled = false;
        }
    }
}
