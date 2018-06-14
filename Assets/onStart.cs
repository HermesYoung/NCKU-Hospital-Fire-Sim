using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onStart : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject hint;
	void Start () {
		//hint.transform.SetParent( player.transform,true);
		hint.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
