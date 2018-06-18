using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closetOpenClose : MonoBehaviour {

	// Use this for initialization
	public Animator closet;
	public bool Open=false;
	void Start () {
		
	}
	public void open(){
		if(Open==true){
        	closet.SetBool("isOpen", false);
			Open=false;
		}
		else if(Open==false){
			closet.SetBool("isOpen", true);
			Open=true;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
