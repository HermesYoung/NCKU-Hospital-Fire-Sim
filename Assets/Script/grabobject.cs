using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class grabobject : MonoBehaviour {
public GameObject stick;
	public GameObject hand;
	public bool hover= false;
	public bool trigger=false;
	public static bool attached=false;
	
	public Rigidbody rb;
	//public transform[] children;
	void Start()
    {
        rb = stick.GetComponent<Rigidbody>();
    }
	public void  attachStickAndPlayer(){
		if(hover&&trigger){
		rb.detectCollisions = false;
			rb.isKinematic=true;
	stick.transform.SetParent(hand.transform,true);
		
			attached=true;
		}
	}
	public void detactchStick(){
		if(attached){
			stick.transform.SetParent(null);
		}
	}
	public void setTrigger(){
		trigger=true;
	}
	public void setNotTrigger(){
		trigger=false;
	}
	public void setHover(){
		hover=true;
	}
	public void setNotHover(){
		hover=false;
	}
	

}
