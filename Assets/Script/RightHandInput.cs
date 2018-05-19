using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandInput : MonoBehaviour {

    public float speed = 0.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("TriggerRightHorizontal");
        float y = Input.GetAxis("TriggerRightVertical");
        x = x * Time.deltaTime * speed;
        y = y * Time.deltaTime * speed;

        transform.Translate(x ,y ,0f);
	}
}
