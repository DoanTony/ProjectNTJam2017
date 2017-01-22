using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public int Player1Point = 0;
    public int Player2Point = 0;
    public MagicBall MagicBall;
    public Text[] ScoreText;

    public int comboP1 = 0;
    public int comboP2 = 0;
    public int breakCombo = 2;
    

    public int WinPoint;

    private int Seconds, Minutes;

    

    private bool BallExist;
	// Use this for initialization
	void Start () {
        Seconds = 0;
        Minutes = 0;
    }
    void Update()
    {
        Seconds += 1 * (int)Time.deltaTime;
        Debug.Log(Seconds);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
      
        ScoreText[2].text = Minutes.ToString("00") + " : " + Seconds.ToString("00");
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
        ScoreText[0].text = "Player 1 : " + StaticData.Player1Score ;
        ScoreText[1].text = "Player 2 : " + StaticData.Player2Score;
        //GUI.TextField(new Rect(Screen.width/2, (Screen.height-Screen.height)+50, 200, 50), "Score : " + Player1Point.ToString() + " | " + Player2Point.ToString());
    }
}
