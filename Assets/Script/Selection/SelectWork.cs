using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectWork : MonoBehaviour {
    public GameObject dsp;
	// Use this for initialization
	void Start () {
		dsp.SetActive(false);
	}
    public void Touch()
    {
			dsp.SetActive(true);
    }
	public void NotTouch()
    {
			dsp.SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
