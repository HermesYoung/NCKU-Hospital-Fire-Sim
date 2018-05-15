using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {
	public Transform cameraPos;
	public float sensitivity;
	public float rotateX, rotateY;
	public  float speed;
	private CharacterController controller;
    public Transform charaMove;
   

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
        cameraPos = GetComponent<Transform>();
        charaMove = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		rotateX += Input.GetAxis ("Mouse X") * sensitivity;
		rotateY -= Input.GetAxis ("Mouse Y") * sensitivity;
		rotateY = Mathf.Clamp (rotateY, -30f, 30f);
		//cameraPos.LookAt (transform);
	   charaMove.localRotation = Quaternion.Euler (0, rotateX, 0);
        cameraPos.localRotation = Quaternion.Euler(rotateY, rotateX, 0);
        if (Input.GetKey(KeyCode.W))
        {
            charaMove.localPosition = Vector3.MoveTowards(charaMove.position, charaMove.position + transform.forward * 2, speed);
        }
		/*
		float moveLR = Input.GetAxis ("Horizontal") * speed;
		float moveFB = Input.GetAxis ("Vertical") * speed;
		Vector3 movement = new Vector3 (moveLR, 0, moveFB);
		movement = transform.rotation * movement;

		controller.SimpleMove (movement * Time.deltaTime);
		*/

	}


}
