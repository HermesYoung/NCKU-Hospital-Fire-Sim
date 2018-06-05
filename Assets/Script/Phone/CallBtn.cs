using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CallBtn : MonoBehaviour {
    Button btn;
	public GameObject P2;
	bool istouch=false;
	bool istrigger=false;
	// Use this for initialization
	void Start () {
		P2.SetActive(false);
	}
   public  void BtnClick()
    {
		if(istouch && istrigger)
		{
			P2.SetActive(true);
    		}
	}
	public void Touch()
    {
		istouch=true;
		BtnClick();
    }
	public void NotTouch()
    {
		istouch=false;
    }
	public void Trigger()
    {
		istrigger=true;
		BtnClick();
    }
	public void NotTrigger()
    {
		istrigger=false;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
