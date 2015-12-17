using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeyLookAt : MonoBehaviour {
    public Text text;
    public bool displayInfo;
    public bool doorOpen = false;

    void Start()
    {
        //text = GameObject.Find("Text").GetComponent<Text> ();
        text.color = Color.clear;
    }

    void Update()
    {
        displayInfo = InteractScript.rayHitKey;
        if (displayInfo)
        {
            text.color = Color.yellow;
            print(text.color.ToString());
        }
        else text.color = Color.clear;
    }
}
