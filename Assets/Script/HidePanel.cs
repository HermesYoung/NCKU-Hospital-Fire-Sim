using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HidePanel : MonoBehaviour {
    public GameObject Panel;
    Button btn;
	// Use this for initialization
    public void hidePanel()
    {
        Panel.gameObject.SetActive(false);
    }
    
    void Start () {
		 btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            hidePanel();
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
