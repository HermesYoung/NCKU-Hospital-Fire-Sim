using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePath : MonoBehaviour {

	public RopeControllerSimple point;
	public Transform target;
	// Use this for initialization
	void Start () {
		point=GetComponent<RopeControllerSimple>();
	}
	
	// Update is called once per frame
	public void Change(){
		point.whatTheRopeIsConnectedTo=target;
	}
}
