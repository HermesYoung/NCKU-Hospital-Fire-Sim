using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEpush : MonoBehaviour {

	// Use this for initialization
	
	public Animator push;
	void Start () {
		
	}
	public void attach(){
		if(FEaim.isAim){
		push.SetBool("isPush" ,true);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
