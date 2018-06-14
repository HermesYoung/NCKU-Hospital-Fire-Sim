using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteachBed : MonoBehaviour {
	
	public GameObject bed;
	public static deteachBed main;
	public GameObject hint;
	// Use this for initialization
	void Start () {
		main=this;
		hint.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void detach(){
		//bed.transform.SetParent(null);
		//rb.detectCollisions = true;
		bed.SetActive(false);
		HasBed.main.hasBed=false;
		hint.SetActive(true);
	}
}
