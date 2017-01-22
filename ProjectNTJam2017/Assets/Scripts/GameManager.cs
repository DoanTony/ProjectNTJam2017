using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text PlayerWon;
    public AudioClip[] Clips;
    private AudioSource audioSource;

    private int ScoreP1,ScoreP2;
    private bool hasPlayerWon;

	// Use this for initialization
	void Start () {
        ScoreP1 = StaticData.Player1Score;
        ScoreP2 = StaticData.Player2Score;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = Clips[0];
        audioSource.Play();
	}
    public void FixedUpdate()
    {
        if(ScoreP1 >= 4)
        {
            Debug.Log("PLAYER1 WIN");
        }
        else if(ScoreP2 >= 4)
        {
            Debug.Log("PLAYER2 WIN");
        }
        else if(StaticData.Minute >= 5)
        {
            if(ScoreP1 > ScoreP2)
            {
                Debug.Log("PLAYER1 WIN");
            }
            else if(ScoreP2 > ScoreP1)
            {
                Debug.Log("PLAYER2 WIN");
            }
            else
            {
                // TIES
            }
        }
    }

    public void PlayBlueScore()
    {
        audioSource.clip = Clips[1];
        audioSource.Play();

    }
    public void PlayRedScore()
    {
        audioSource.clip = Clips[2];
        audioSource.Play();

    }
    // Update is called once per frame
    void Update () {
		
	}
}
