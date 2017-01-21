using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneAction : MonoBehaviour {

    GameObject Rune;
    public GameObject ParticleP1;
    public GameObject ParticleP2;
    public GameObject ParticleP3;
    public GameObject ParticleP4;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        #region Player1
        //Player 1 Controller

        #region A_Rune
        if (Input.GetButtonDown("P1Fire1"))
        {
            Rune = GameObject.Find("RuneAP1");
            Instantiate(ParticleP3, new Vector3(Rune.transform.position.x, Rune.transform.position.y +10, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP3, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 10, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1 Rune A = Activated!");
        }
        #endregion

        #region B_Rune_Up_and_Down
        if (Input.GetAxis("P1Vertical")> 0.5 && Input.GetButtonDown("P1Fire2"))
        {
            Rune = GameObject.Find("RuneBUpP1");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1 Rune B-UP = Activated!");
        }
        if (Input.GetAxis("P1Vertical") < -0.5 && Input.GetButtonDown("P1Fire2"))
        {
            Rune = GameObject.Find("RuneBDownP1");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1 Rune B-Down = Activated!");
        }
        #endregion

        #region X_Rune_Up_and_Down
        if (Input.GetAxis("P1Vertical") > 0.5 && Input.GetButtonDown("P1Fire3"))
        {
            Rune = GameObject.Find("RuneXUpP1");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1  Rune X-UP = Activated!");
        }
        if (Input.GetAxis("P1Vertical") < -0.5 && Input.GetButtonDown("P1Fire3"))
        {
            Rune = GameObject.Find("RuneXDownP1");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1  Rune X-Down = Activated!");
        }
        #endregion

        #region Y_Rune_Up_and_Down
        if (Input.GetAxis("P1Vertical") > 0.5 && Input.GetButtonDown("P1Fire4"))
        {
            Rune = GameObject.Find("RuneYUpP1");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1  Rune Y-UP = Activated!");
        }
        if (Input.GetAxis("P1Vertical") < -0.5 && Input.GetButtonDown("P1Fire4"))
        {
            Rune = GameObject.Find("RuneYDownP1");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P1  Rune Y-Down = Activated!");
        }
        #endregion

        #endregion

        #region Player2
        //Player 2 Controller

        #region A_Rune
        if (Input.GetButtonDown("P2Fire1"))
        {
            Rune = GameObject.Find("RuneAP2");
            Instantiate(ParticleP3, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP3, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2 Rune A = Activated");
        }
        #endregion

        #region B_Rune_Up_and_Down
        if (Input.GetAxis("P2Vertical") > 0.5 && Input.GetButtonDown("P2Fire2"))
        {
            Rune = GameObject.Find("RuneBUpP2");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2  Rune B-UP = Activated!");
        }
        if (Input.GetAxis("P2Vertical") < -0.5 && Input.GetButtonDown("P2Fire2"))
        {
            Rune = GameObject.Find("RuneBDownP2");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2  Rune B-Down = Activated!");
        }
        #endregion

        #region X_Rune_Up_and_Down
        if (Input.GetAxis("P2Vertical") > 0.5 && Input.GetButtonDown("P2Fire3"))
        {
            Rune = GameObject.Find("RuneXUpP2");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2  Rune X-UP = Activated!");
        }
        if (Input.GetAxis("P2Vertical") < -0.5 && Input.GetButtonDown("P2Fire3"))
        {
            Rune = GameObject.Find("RuneXDownP2");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2  Rune X-Down = Activated!");
        }
        #endregion

        #region Y_Rune_Up_and_Down
        if (Input.GetAxis("P2Vertical") > 0.5 && Input.GetButtonDown("P2Fire4"))
        {
            Rune = GameObject.Find("RuneYUpP2");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2  Rune Y-UP = Activated!");
        }
        if (Input.GetAxis("P2Vertical") < -0.5 && Input.GetButtonDown("P2Fire4"))
        {
            Rune = GameObject.Find("RuneYDownP2");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Debug.Log("P2  Rune Y-Down = Activated!");
        }
        #endregion

        #endregion

    }
}
