using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class grabobject : MonoBehaviour {
	public GameObject stick;
	public GameObject hand;
	public bool hover= false;
	public bool trigger=false;
	public bool attached=false;
	
	public static grabobject main;
	public Rigidbody rb;
	//public transform[] children;
	void Start()
    {
        rb = stick.GetComponent<Rigidbody>();
		main=this;
    }
	public void  attachStickAndPlayer(){
		if(hand.GetComponent<Hand>().controller.GetHairTrigger()){
		rb.detectCollisions = false;
			rb.isKinematic=true;
	stick.transform.SetParent(hand.transform,true);
		

			StickerPersonMove.main.attached=true;
			this.attached=true;
		}
	}
	public void detactchStick(){
		if(hand.GetComponent<Hand>().controller.GetHairTrigger()&&attached){
		rb.detectCollisions = true;
			stick.transform.SetParent(null);
		}
			
	
	}
	public void setTrigger(){
		trigger=true;
		attachStickAndPlayer();
	}
	public void setNotTrigger(){
		trigger=false;
	}
	public void setHover(){
		hover=true;
		attachStickAndPlayer();
	}
	public void setNotHover(){
		hover=false;
	}
	void update(){
		
	}
	void OnControllerColliderHit(ControllerColliderHit hit){
		print("123");
		rb.isKinematic=true;
		stick.transform.SetParent(hit.controller.transform,true);

	}

}
