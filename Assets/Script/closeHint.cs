using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeHint : MonoBehaviour {

	// Use this for initialization
	public GameObject hint;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void closeWindow(){
		if(hint.activeSelf==true)
		{
			hint.SetActive(false);
		}
	}
}
