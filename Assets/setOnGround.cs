using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setOnGround : MonoBehaviour {

public GameObject bed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		bed.transform.position=new Vector3(bed.transform.position.x,0f,bed.transform.position.z);
		bed.transform.rotation=new  Quaternion(0,bed.transform.rotation.y,0,bed.transform.rotation.w);
	}
}
