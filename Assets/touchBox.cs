using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchBox : MonoBehaviour {

	public GameObject speaker;
	public GameObject flashlight;
	public GameObject stick;
	// Use this for initialization
	void Start () {
		speaker.SetActive(false);
		flashlight.SetActive(false);
		stick.SetActive(false);
	}
	public void appear(){
		speaker.SetActive(true);
		flashlight.SetActive(true);
		stick.SetActive(true);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
