using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour {

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
    void BtnClick() {
        OutText.text = OutText.text + btn.GetComponentInChildren<Text>().text;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
