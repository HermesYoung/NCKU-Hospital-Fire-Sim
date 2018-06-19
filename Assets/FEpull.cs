using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FEpull : MonoBehaviour {

	public Animator pull;
	public GameObject obj; 

	public static bool pullCheck=false;
	// Use this for initialization
	void Start () {
		
	}
	public void attach(){
		pull.SetBool("isPull" ,true);
		//obj.SetActive(false);
		pullCheck=true;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
