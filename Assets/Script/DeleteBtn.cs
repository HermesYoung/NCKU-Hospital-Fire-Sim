using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeleteBtn : MonoBehaviour {
    public Text OutText;
    Button btn;
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
        OutText.text = "";
    }
	// Update is called once per frame
	void Update () {
		
	}
}
