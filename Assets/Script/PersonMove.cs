using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMove : MonoBehaviour {
    public Animator person;
	// Use this for initialization
	void Start () {
		
	}
	public void  Move(){
        person.SetBool("isMove", true);
    }
	// Update is called once per frame
	void Update () {
	}

}
