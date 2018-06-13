using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerPersonMove : MonoBehaviour {
	public Animator person;	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("stick")){
			person.SetBool("isMove",true);
		}
    }
}
