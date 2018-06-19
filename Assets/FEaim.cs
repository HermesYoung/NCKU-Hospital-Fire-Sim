using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEaim : MonoBehaviour {

	// Use this for initialization
	public Animator aim;

	public GameObject pipe;
	public static bool isAim=false;
	void Start () {
		
	}
	public void attach(){
		if(FEpull.pullCheck){
			print(FEpull.pullCheck);
			pipe.SetActive(false);
			aim.SetBool("isAim" ,true);
			isAim=true;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
