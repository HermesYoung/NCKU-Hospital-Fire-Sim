using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowPanel : MonoBehaviour {
    public GameObject Panel;
    Button btn;

    public void showPanel()
    {
        Panel.gameObject.SetActive(true);
    }
	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            showPanel();
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
