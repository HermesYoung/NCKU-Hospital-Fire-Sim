using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedLight : MonoBehaviour {

	// Use this for initialization
	
	float tempTime = 0.001f; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(SelectWork.main.jobSelect==3)
		{
			
			this.gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");

		}
	}
}
