using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneGame : MonoBehaviour {
	bool istouch = false;
	bool istrigger = false;
	
	// Use this for initialization
	void Start () {
		
	}
	public void Switch(){
		if(istouch && istrigger){
			SceneManager.LoadScene("game");
		}
	}
	public void Touch(){
		istouch = true;
		Switch();
	}
	public void NotTouch(){
		istouch = false;
	}
	public void Trigger(){
		istrigger = true;
		Switch();
	}
	public void NotTrigger(){
		istrigger = false;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
