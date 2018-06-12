using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabobject : MonoBehaviour {
	public GameObject obj;
	public GameObject HandRight;
	public GameObject HandLeft;
	public Rigidbody rb;
	public string hand;
	public bool getstick=false;
	public bool getspeaker=false;
	public static  grabobject main;
	// Use this for initialization
	void Start () {
		main=this;
		rb = obj.GetComponent<Rigidbody>();
	}
	public void grab()
	{
		if(hand == "right"){
			obj.transform.SetParent(HandRight.transform,true);
		}else{
			obj.transform.SetParent(HandLeft.transform,true);
		}
		rb.detectCollisions = false;
		getstick=true;
	}
	void OnCollisionEnter (Collision collision) 
     {
	 	Debug.Log("enter");
	 	if (collision.gameObject.name == "Hand1")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
           Debug.Log("Do something here1");
			obj.transform.SetParent(  HandRight.transform,true);
        }
		if (collision.gameObject.name == "Hand2")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
           Debug.Log("Do something here2");
			obj.transform.SetParent(HandLeft.transform,true);
        }
		if (collision.gameObject.name == "flashlight")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
           Debug.Log("Do something here1");
			obj.transform.SetParent(  HandRight.transform,true);
        }
		rb.detectCollisions = false;
     }
	// Update is called once per frame
	void Update () {
	
	}
}
