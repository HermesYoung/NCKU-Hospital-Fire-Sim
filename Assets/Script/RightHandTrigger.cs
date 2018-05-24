using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandTrigger : MonoBehaviour {
    private SteamVR_TrackedObject trackedObjectRight;
    private SteamVR_TrackedObject trackedObjectLeft;
   
    //GameObject controllerObjectLeft = GameObject.Find("Controller (left)");
    private SteamVR_Controller.Device controllerRight
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObjectRight.index);
        }
    }
    private SteamVR_Controller.Device controllerLeft
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObjectLeft.index);
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (controllerRight.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + controllerRight.GetAxis());
        }

        // 2
        if (controllerRight.GetHairTriggerDown())
        {
            Debug.Log(gameObject.name + " Trigger Press");
        }

        // 3
        if (controllerRight.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " Trigger Release");
        }

        // 4
        if (controllerRight.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Press");
        }

        // 5
        if (controllerRight.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log(gameObject.name + " Grip Release");
        }
    }

    void Awake()
    {
        GameObject controllerObjectRight = GameObject.Find("Controller (right)");
        trackedObjectRight = controllerObjectRight.GetComponent<SteamVR_TrackedObject>();
        //trackedObjectLeft = controllerObjectLeft.GetComponent<SteamVR_TrackedObject>();
    }

}
