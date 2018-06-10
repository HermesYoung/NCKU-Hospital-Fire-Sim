using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachBed : MonoBehaviour {

	public GameObject bed;
	public GameObject player;
	
	public void  attachBedAndPlayer(){
		bed.transform.SetParent(player.transform,true);
	}
	public void detachBed(){
		bed.transform.SetParent(null);
	}
}
