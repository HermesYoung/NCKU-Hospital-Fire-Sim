using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerPersonMove : MonoBehaviour {
	public Animator person;	
	// Use this for initialization
	void Start () {
		
	}
	public void  Move(){
		if(grabobject.main.getstick == true){
        		person.SetBool("isMove", true);
		}
    }
	// Update is called once per frame
	void Update () {
		
	}
}
