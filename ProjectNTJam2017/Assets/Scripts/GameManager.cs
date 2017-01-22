using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text PlayerWon;
    public AudioClip[] Clips;
    private AudioSource audioSource;

    private bool hasPlayerWon;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = Clips[0];
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
