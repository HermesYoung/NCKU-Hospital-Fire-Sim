using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectWork : MonoBehaviour {
    public GameObject dsp;
	public GameObject hint;
	public GameObject selectWindow;
	public bool canClose;
	public bool isHover;
	public static int jobType=-1;
	
	
	// Use this for initialization
	void Start () {
		dsp.SetActive(false);
		hint.SetActive(false);
		canClose=false;
		isHover=false;
		
	}
    public void Touch()
    {
			dsp.SetActive(true);
			this.isHover=true;
    }
	public void NotTouch()
    {
			dsp.SetActive(false);
			this.isHover=false;
    }
	public void Select()
    {
		if(this.isHover){
			dsp.SetActive(false);
			hint.SetActive(true);
			if(this.gameObject.tag=="A")
			{
				bedLight.main.jobSelect=1;
			}
			if(this.gameObject.tag=="B")
			{
				bedLight.main.jobSelect=2;
			}
			if(this.gameObject.tag=="C")
			{
				jobType=3;
				bedLight.main.jobSelect=3;
			}
		}
    }
	public void closeWindow(){

		if(canClose&&hint.activeSelf==true)
		{
			hint.SetActive(false);
			canClose=false;
			selectWindow.SetActive(false);
		}
		canClose=true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
