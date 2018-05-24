using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowPanel : MonoBehaviour {
    public GameObject Panel1;
    public GameObject Panel2;
    Button btn;

    public void showPanel()
    {
        Panel2.gameObject.SetActive(true);
    }
    public void hidePanel()
    {
        Panel1.gameObject.SetActive(false);
    }
	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            showPanel();
            hidePanel();
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
