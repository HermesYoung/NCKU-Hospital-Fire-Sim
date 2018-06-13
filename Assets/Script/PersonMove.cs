using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMove : MonoBehaviour {
	public GameObject stick;
	public bool hit=false;
    public Animator person;
	// Use this for initialization
	void Start () {
		
	}
	public void  Move(){
		if(hit){
        person.SetBool("isMove", true);
		}
    }
	// Update is called once per frame
	void Update () {
		hit=grabobject.attached;
	}

}
