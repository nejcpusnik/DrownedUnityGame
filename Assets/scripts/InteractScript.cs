using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour {
    public static bool rayHitDoor = false;
    public static bool rayHitKey = false;

    void Start () {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Door")
            {
                rayHitDoor = true;
            } else {
                rayHitDoor = false;
            }
            if (hit.collider.tag == "Key")
            {
                rayHitKey = true;
            }
            else
            {
                rayHitKey = false;
            }
        }

    }
}
