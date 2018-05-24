using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CallBtn : MonoBehaviour {
    Button btn;
    public Animator text;
	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            BtnClick();
        });
	}
    void BtnClick()
    {
        text.SetBool("isHidden", false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
