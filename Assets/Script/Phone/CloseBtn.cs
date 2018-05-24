using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloseBtn : MonoBehaviour {
    Button btn;
    public Animator panel1;
    public Animator panel2;
    public Animator panel3;
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
        panel1.SetBool("isHidden", true);
        panel2.SetBool("isHidden", true);
        panel3.SetBool("isHidden", false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
