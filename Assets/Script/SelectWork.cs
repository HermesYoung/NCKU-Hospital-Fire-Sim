using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectWork : MonoBehaviour {
    Button btnOK;
    public Animator panel;
	// Use this for initialization
	void Start () {
        btnOK = GetComponent<Button>();
        btnOK.onClick.AddListener(delegate
        {
            BtnClick();
        });
	}
    void BtnClick()
    {
        panel.SetBool("isHidden", true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
