using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour {
private bool isUIopen=false;

public GameObject UI;
	// Use this for initialization
	void Start () {
		UI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
public void UIToggle(){
if(!isUIopen){
	
	
	UI.SetActive(true);
	}else{
	
		UI.SetActive(false);
	}
}
public void  setTouch(){
	isUIopen=!isUIopen;
}

}
