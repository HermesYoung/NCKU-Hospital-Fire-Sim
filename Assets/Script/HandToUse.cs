using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandToUse : MonoBehaviour {

	// Use this for initialization
	public GameObject HandRight;
	public GameObject HandLeft;
	public string hand;
	public static HandToUse main;
	void Start () {
		main=this;
	}
	public void SetRight(){
		hand="right";
	}
	public void SetLeft(){
		hand="left";
	}
	// Update is called once per frame
	void Update () {
		
	}
}
