using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	// Use this for initialization
	void Start () {
		p1.SetActive(true);
		p2.SetActive(false);
		p3.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
