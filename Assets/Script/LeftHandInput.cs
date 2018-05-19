using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandInput : MonoBehaviour {

    public float speed = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("TriggerLeftHorizontal");
        float y = Input.GetAxis("TriggerLeftVertical");
        x = x * Time.deltaTime * speed;
        y = y * Time.deltaTime * speed;

        transform.Translate(x ,y ,0f);
	}
}
