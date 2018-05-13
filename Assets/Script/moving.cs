using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {
	public Transform cameraPos;
	public float sensitivity;
	public float rotateX, rotateY;
	public  float speed;
	private CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {
		rotateX += Input.GetAxis ("Mouse X") * sensitivity;
		rotateY -= Input.GetAxis ("Mouse Y") * sensitivity;
		rotateY = Mathf.Clamp (rotateY, -30f, 30f);
		cameraPos.LookAt (transform);
		transform.localRotation = Quaternion.Euler (rotateY, rotateX, 0);
		/*
		float moveLR = Input.GetAxis ("Horizontal") * speed;
		float moveFB = Input.GetAxis ("Vertical") * speed;
		Vector3 movement = new Vector3 (moveLR, 0, moveFB);
		movement = transform.rotation * movement;

		controller.SimpleMove (movement * Time.deltaTime);
		*/

	}


}
