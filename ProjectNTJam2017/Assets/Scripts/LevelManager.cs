using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public int Player1Point = 0;
    public int Player2Point = 0;

    public int comboP1 = 0;
    public int comboP2 = 0;
    public int breakCombo = 2;

    public int WinPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.TextField(new Rect(Screen.width/2, (Screen.height-Screen.height)+50, 200, 50), "Score : " + Player1Point.ToString() + " | " + Player2Point.ToString());
    }
}
