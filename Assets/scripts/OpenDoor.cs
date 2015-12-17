using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OpenDoor : MonoBehaviour {
    public GameObject door;
    public bool allowOpen = false;
    public string textString;
    public Text text;
    public float fadeTime;
    public bool displayInfo;
    public bool doorOpen = false;

    void Start () {
        //text = GameObject.Find("Text").GetComponent<Text> ();
        text.color = Color.clear;
    }
	
	void Update () {
        displayInfo = InteractScript.rayHitDoor;
        if (displayInfo && allowOpen) {
            text.color = Color.yellow;
            print(text.color.ToString());
        }
        else text.color = Color.clear;
        if (Input.GetKeyDown("e") && displayInfo && allowOpen == true)
        {
            door.GetComponent<Animation>().Play();
            this.doorOpen = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        allowOpen = true;
    }

    void OnTriggerExit(Collider other)
    {
        allowOpen = false;
    }

}
