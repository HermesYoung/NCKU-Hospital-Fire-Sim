using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeleteBtn : MonoBehaviour {
    public Text OutText;
    Button btn;
	bool istouch=false;
	bool istrigger=false;
	// Use this for initialization
	void Start () {
		 btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            BtnClick();
        });
	}
    public void BtnClick() {
		if(istouch && istrigger)
		{
       		 OutText.text = "";
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
	void Update () {
		
	}
}