using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour {

    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject UI;
    int count = 0;
	// Use this for initialization
	void Start () {
        s1.SetActive(false);
        s2.SetActive(false);
        s3.SetActive(false);
        s4.SetActive(false);
	}
	public void get_sentence(){
        count++;
        print();
    }
    void print()
    {
        switch (count)
        {
            case 1:
                s1.SetActive(true);
                break;
            case 2:
                s2.SetActive(true);
                break;
            case 3:
                s3.SetActive(true);
                break;
            case 4:
                s4.SetActive(true);
                break;
            default:
                UI.SetActive(false);
                break;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
