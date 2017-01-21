using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public int Player1Point = 0;
    public int Player2Point = 0;
    public MagicBall MagicBall;

    public bool PowerAttackP1 = false;
    public bool PowerAttackP2 = false;

    public int comboMax = 5;


    public int comboP1 = 0;
    public int comboP2 = 0;
    public int breakCombo = 2;

    public int WinPoint;
    

    private bool BallExist;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (GameObject.FindGameObjectWithTag("MagicBall") == null)
        {
            BallExist = false;
        }
        else
        {
            BallExist = true;
        }

        if(BallExist == false)
        {
            RestartBall();
        }
	}

    void RestartBall()
    {
        Instantiate(MagicBall, new Vector3(0, 0, 0), Quaternion.identity);
    }
    void OnGUI()
    {
        GUI.TextField(new Rect(Screen.width/2, (Screen.height-Screen.height)+50, 200, 50), "Score : " + Player1Point.ToString() + " | " + Player2Point.ToString());
    }
}
