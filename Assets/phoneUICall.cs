using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class phoneUICall : MonoBehaviour {
    public GameObject UI;
    private SteamVR_TrackedController controller;
    private bool isCollide=false;

    private void OnEnable(){
        controller = GetComponent<SteamVR_TrackedController>();
        controller.TriggerClicked += HandleTriggerClicked;
        
    }
    private void OnDisable()
    {
        controller.TriggerClicked -= HandleTriggerClicked;
       
    }
    private void HandleTriggerClicked(object sender,ClickedEventArgs e)
    {
        if (isCollide&&!UI.activeSelf)
        {
            UI.SetActive(true);
        }
    }
    // Use this for initialization
    void Start () {
        
        UI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        isCollide = true;
    }
    void OnTriggerStay(Collider other)
    {
        isCollide = true;
    }
    void OnTriggerExit(Collider other)
    {
        isCollide = false;
    }

}
