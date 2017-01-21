using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneAction : MonoBehaviour {

    GameObject Rune;
    public GameObject ParticleP1;
    public GameObject ParticleP2;
    public GameObject ParticleP3;
    public GameObject ParticleP4;

    LevelManager levelManager;

    //Bool Player 1
    public bool P1A;
    public bool P1BUp;
    public bool P1BDown;
    public bool P1YUp;
    public bool P1YDown;
    public bool P1XUp;
    public bool P1XDown;

    //Bool Player 2
    public bool P2A;
    public bool P2BUp;
    public bool P2BDown;
    public bool P2YUp;
    public bool P2YDown;
    public bool P2XUp;
    public bool P2XDown;


    void Start()
    {
        levelManager = GetComponent<LevelManager>();
    }
 
	
	// Update is called once per frame
	void Update () {

        #region Player1
        //Player 1 Controller

        #region A_Rune
        if (Input.GetButtonDown("P1Fire1"))
        {
            Rune = GameObject.Find("RuneAP1");
            Instantiate(ParticleP3, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 10, Rune.transform.position.z), Quaternion.identity);
            P1A = true;
            StartCoroutine(Timer(P1A, "P1A", 2f, 1));

            if (levelManager.comboP1 != 5)
            {
                levelManager.comboP1 += 1;
            }else if (levelManager.comboP1 == 5)
            {
                levelManager.PowerAttackP1 = true;
            }
            if(levelManager.comboP2 >= 2)
            {
                levelManager.comboP2 = 0;
            }
        }
        #endregion

        #region B_Rune_Up_and_Down
        if (Input.GetAxis("P1Vertical") < -0.5 && Input.GetButtonDown("P1Fire2"))
        {
            Rune = GameObject.Find("RuneBUpP1");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P1BUp = true;
            StartCoroutine(Timer(P1BUp, "P1BUp", 2f, 1));
        }
        if (Input.GetAxis("P1Vertical") > 0.5 && Input.GetButtonDown("P1Fire2"))
        {
            Rune = GameObject.Find("RuneBDownP1");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P1BDown = true;
            StartCoroutine(Timer(P1BDown, "P1BDown", 2f, 1));
        }
        #endregion

        #region X_Rune_Up_and_Down
        if (Input.GetAxis("P1Vertical") < -0.5 && Input.GetButtonDown("P1Fire3"))
        {
            Rune = GameObject.Find("RuneXUpP1");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P1XUp = true;
            StartCoroutine(Timer(P1XUp, "P1XUp", 2f, 1));
        }
        if (Input.GetAxis("P1Vertical") > 0.5 && Input.GetButtonDown("P1Fire3"))
        {
            Rune = GameObject.Find("RuneXDownP1");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P1XDown = true;
            StartCoroutine(Timer(P1XDown, "P1XDown", 2f, 1));
        }
        #endregion

        #region Y_Rune_Up_and_Down
        if (Input.GetAxis("P1Vertical") < -0.5 && Input.GetButtonDown("P1Fire4"))
        {
            Rune = GameObject.Find("RuneYUpP1");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P1YUp = true;
            StartCoroutine(Timer(P1YUp, "P1YUp", 2f, 1));
        }
        if (Input.GetAxis("P1Vertical") > 0.5 && Input.GetButtonDown("P1Fire4"))
        {
            Rune = GameObject.Find("RuneYDownP1");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P1YDown = true;
            StartCoroutine(Timer(P1YDown, "P1YDown", 2f, 1));
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
            P2A = true;
            StartCoroutine(Timer(P2A, "P2A", 2f, 2));
        }
        #endregion

        #region B_Rune_Up_and_Down
        if (Input.GetAxis("P2Vertical") < -0.5 && Input.GetButtonDown("P2Fire2"))
        {
            Rune = GameObject.Find("RuneBUpP2");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P2BUp = true;
            StartCoroutine(Timer(P2BUp, "P2BUp", 2f, 2));
        }
        if (Input.GetAxis("P2Vertical") > 0.5 && Input.GetButtonDown("P2Fire2"))
        {
            Rune = GameObject.Find("RuneBDownP2");
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP2, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P2BDown = true;
            StartCoroutine(Timer(P2BDown, "P2BDown", 2f, 2));
        }
        #endregion

        #region X_Rune_Up_and_Down
        if (Input.GetAxis("P2Vertical") < -0.5 && Input.GetButtonDown("P2Fire3"))
        {
            Rune = GameObject.Find("RuneXUpP2");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P2XUp = true;
            StartCoroutine(Timer(P2XUp, "P2XUp", 2f, 2));
        }
        if (Input.GetAxis("P2Vertical") > 0.5 && Input.GetButtonDown("P2Fire3"))
        {
            Rune = GameObject.Find("RuneXDownP2");
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP1, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P2XDown = true;
            StartCoroutine(Timer(P2XDown, "P2XDown", 2f, 2));
        }
        #endregion

        #region Y_Rune_Up_and_Down
        if (Input.GetAxis("P2Vertical") < -0.5 && Input.GetButtonDown("P2Fire4"))
        {
            Rune = GameObject.Find("RuneYUpP2");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P2YUp = true;
            StartCoroutine(Timer(P2YUp, " P2YUp", 2f, 2));
        }
        if (Input.GetAxis("P2Vertical") > 0.5 && Input.GetButtonDown("P2Fire4"))
        {
            Rune = GameObject.Find("RuneYDownP2");
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            Instantiate(ParticleP4, new Vector3(Rune.transform.position.x, Rune.transform.position.y + 5, Rune.transform.position.z), Quaternion.identity);
            P2YDown = true;
            StartCoroutine(Timer(P2YDown, "P2YDown", 2f, 2));
        }
        #endregion

        #endregion

    }




    private IEnumerator Timer(bool variable,string name, float waitTime, int idPlayer)
    {
            yield return new WaitForSeconds(waitTime);
        if(idPlayer == 1)
        {
            #region Player 1
            if (name == "P1A")
            {
                P1A = false;
            }
            else if (name == "P1XUp")
            {
                P1XUp = false;
            }
            else if (name == "P1XDown")
            {
                P1YDown = false;
            }
            else if (name == "P1YUp")
            {
                P1YUp = false;
            }
            else if (name == "P1YDown")
            {
                P1YDown = false;
            }
            else if (name == "P1BUp")
            {
                P1BUp = false;
            }
            else if (name == "P1BDown")
            {
                P1BDown = false;
            }
#endregion
        }
        else if(idPlayer == 2)
        {
            #region Player 2
            if (name == "P2A")
            {
                P2A = false;
            }
            else if (name == "P2XUp")
            {
                P2XUp = false;
            }
            else if (name == "P2XDown")
            {
                P2YDown = false;
            }
            else if (name == "P2YUp")
            {
                P2YUp = false;
            }
            else if (name == "P2YDown")
            {
                P2YDown = false;
            }
            else if (name == "P2BUp")
            {
                P2BUp = false;
            }
            else if (name == "P2BDown")
            {
                P2BDown = false;
            }
            #endregion
        }
    }
}
