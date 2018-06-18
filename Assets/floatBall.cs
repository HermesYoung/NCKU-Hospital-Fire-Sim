using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatBall : MonoBehaviour {
	public Animator ball;
	public Animator button;
	// Use this for initialization
	void Start () {
		
	}
	
	public void attach(){
		ball.SetBool("isUp", true);
		button.SetBool("isSpin", true);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
