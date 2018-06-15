using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerPersonMove : MonoBehaviour {
	public Animator person;	
	public bool attached;

	public static StickerPersonMove main;
	// Use this for initialization
	void Start () {
		main=this;
	}
	public void  Move(){
		if(attached==true)
        	person.SetBool("isMove", true);
    }
	// Update is called once per frame
	void Update () {
		
	}
	/* void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("stick")){
			person.SetBool("isMove",true);
		}
    }
	public Transform explosionPrefab;

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        Instantiate(explosionPrefab, pos, rot);
        Destroy(gameObject);
    }*/
}
