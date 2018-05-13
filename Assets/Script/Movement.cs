using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Transform fl;
	// Use this for initialization
	void Start () {
        fl = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        fl.rotation = new Quaternion(fl.rotation.x, fl.rotation.y + Input.GetAxis("Mouse X"), fl.rotation.z, fl.rotation.w);
		
	}
}
