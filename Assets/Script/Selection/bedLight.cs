using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedLight : MonoBehaviour {

	// Use this for initialization
	public int jobSelect;
	public static  bedLight  main; 
	float tempTime = 0.01f; 
	void Start () {
		main=this;
	}
	
	// Update is called once per frame
	void Update () {
		print(jobSelect);
		
		if(jobSelect==3)
		{
			if (tempTime <= 0.5) {
				tempTime += 0.01f;
				this.gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
			}  
        	else  if(tempTime<1&&tempTime>0.5)
			{
				tempTime += 0.01f;  
				this.gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
			}
			else{
				tempTime=0;
			}
		}
	}
}
