using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    EventSystem eventSystem;
    Vector3 postionPlay;
    Vector3 positionOption;
    Vector3 positionQuit;
    Animator anim; 
    bool optionOpen = false;

   public  GameObject option;

	// Use this for initialization
	void Start () {
        positionOption = new Vector3(0,188,0);
        postionPlay = new Vector3(0, 123, 0);
        positionQuit = new Vector3(0, 60, 0);
        anim = GameObject.Find("Canvas").GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Option()
    {
        if (optionOpen == false)
        {
            anim.Play("Option");
            optionOpen = true;
            option.active = true;
        }
        else
        {
            anim.Play("OptionOut");
            optionOpen = false;
            option.active = false;
        }
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void play()
    {
        Application.LoadLevel("TonyScene");
    }


}
