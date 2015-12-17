using UnityEngine;
using System.Collections;

public class FlashlightControl : MonoBehaviour {
    public Light flashlightInner;
    public Light flashlightOuter;
    public bool flashlightOn = true;
    public float flashlightInnerOriginalIntensity;
    public float flashlightOuterOriginalIntensity;
    // Use this for initialization
    void Start () {
        flashlightInner = GameObject.Find("Spotlight").GetComponent<Light>();
        flashlightOuter = GameObject.Find("Spotlight_2").GetComponent<Light>();
        flashlightInnerOriginalIntensity = flashlightInner.intensity;
        flashlightOuterOriginalIntensity = flashlightOuter.intensity;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            if (flashlightOn)
            {
                flashlightOn = false;
                flashlightInner.intensity = 0;
                flashlightOuter.intensity = 0;
            }
            else {
                flashlightOn = true;
                flashlightInner.intensity = flashlightInnerOriginalIntensity;
                flashlightOuter.intensity = flashlightOuterOriginalIntensity;
            }
            
        }
        
    }
}
