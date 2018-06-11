using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachBed : MonoBehaviour {

	public GameObject bed;
	public GameObject player;
	public Rigidbody rb;
	//public transform[] children;
	void Start()
    {
        rb = bed.GetComponent<Rigidbody>();
    }
	public void  attachBedAndPlayer(){
		if( HasBed.main.hasBed==false){
			bed.transform.SetParent(player.transform,true);
			rb.detectCollisions = false;		
			HasBed.main.hasBed=true;
			deteachBed.main.bed=this.bed;
			//Debug.Log(player.transform.childCount);
			//children=player.GetComponentsInChildren<transform>();
			//Debug.Log(children);
		}
	}
	public void detachBed(){
			bed.transform.SetParent(null);	
			//rb.detectCollisions = true;
			bed.SetActive(false);
	}
}
