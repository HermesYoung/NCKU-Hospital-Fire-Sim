using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloseBtn : MonoBehaviour {
    public GameObject panel1;
    public GameObject panel2;
	public GameObject panel3;
	// Use this for initialization
	void Start () {
		 panel3.SetActive(false);
	}
    public void BtnClick()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
		panel3.SetActive(true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}