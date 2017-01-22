using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{

    private Rigidbody selfRigidbody; 
    public int BallForce;
    private int BallDirectionHorizontal,BallDirectionVertical;
    private bool IsBallMoving;
    RuneAction runeAction;
    public float VelMax;
    public float VelMin;
    public bool RandomBallB = true;
    LevelManager levelManager;
    public bool inputAble = false;

    private float Timer;
    private bool IsTimerActive;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("RandomBall", 2.0f, 5f);
        IsBallMoving = false;
        selfRigidbody = GetComponent<Rigidbody>();
        BallDirectionHorizontal = Random.Range(-1, 2);
        BallDirectionVertical = Random.Range(-1, 2);
        IsTimerActive = true;
        runeAction = GameObject.Find("Arena").GetComponent<RuneAction>();
        levelManager = GameObject.Find("Arena").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BallDirectionHorizontal == 0)
        {
            BallDirectionHorizontal = Random.Range(-1, 2);
        }
        else
        {
            if (BallDirectionVertical == 0)
            {
                BallDirectionVertical = Random.Range(-1, 2);
            }
            else
            {
                if(IsTimerActive)
                {
                    Timer += Time.deltaTime;
                    if(Timer >= 3)
                    {
                        MoveBall();
                        inputAble = true;
                        Timer = 0;
                        IsTimerActive = false;
                    }
                }
                
            }
            
        }
    }
    public void func(Vector3 _opposite, float _hu)
    {
        
        selfRigidbody.velocity = _opposite * _hu;

        float speed = Vector3.Magnitude(selfRigidbody.velocity);  // test current object speed

       // Debug.Log(speed);
        //== TESTING ==\\
        if (speed > VelMax)

        {
            selfRigidbody.velocity = new Vector3((selfRigidbody.velocity.x/Mathf.Abs(selfRigidbody.velocity.x))*VelMax,selfRigidbody.velocity.y, (selfRigidbody.velocity.z / Mathf.Abs(selfRigidbody.velocity.z)) * VelMax) * -1;
        }
       
    }

    void OnTriggerStay(Collider other)
    {
        float hu = 1.5f;
        Vector3 opposite = selfRigidbody.velocity * -1;
        if(inputAble == true)
        {
            if (other.tag == "Rune")
            {
                RandomBallB = false;
                #region Player1
                if (other.name == "RuneXDownP1" && runeAction.P1XDown == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                else if (other.name == "RuneXUpP1" && runeAction.P1XUp == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                else if (other.name == "RuneYUpP1" && runeAction.P1YUp == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                else if (other.name == "RuneYDownP1" && runeAction.P1YDown == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                else if (other.name == "RuneBDownP1" && runeAction.P1BDown == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                else if (other.name == "RuneBUpP1" && runeAction.P1BUp == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                else if (other.name == "RuneAP1" && runeAction.P1A == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP1();
                }
                #endregion

                #region Player2
                if (other.name == "RuneXDownP2" && runeAction.P2XDown == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                else if (other.name == "RuneXUpP2" && runeAction.P2XUp == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                else if (other.name == "RuneYUpP2" && runeAction.P2YUp == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                else if (other.name == "RuneYDownP2" && runeAction.P2YDown == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                else if (other.name == "RuneBDownP2" && runeAction.P2BDown == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                else if (other.name == "RuneBUpP2" && runeAction.P2BUp == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                else if (other.name == "RuneAP2" && runeAction.P2A == true)
                {
                    func(opposite, hu);
                    runeAction.ComboFuncP2();
                }
                #endregion

                //Debug.Log("Velocity : " + selfRigidbody.velocity);
            }
            else if (other.tag == "GoalP1")
            {
                StaticData.Player2Score++;
                Destroy(gameObject);
                if (levelManager.Player1Point == levelManager.WinPoint)
                {
                    //Player 1 WIN
                }
            }
            else if (other.tag == "GoalP2")
            {
                StaticData.Player1Score++;
                Destroy(gameObject);
                if (levelManager.Player2Point == levelManager.WinPoint)
                {
                    //Player 2 WIN
                }
            }
        }
        


    }

    void OnColliderEnter(Collision col)
    {
        RandomBallB = false;
    }

    public void MoveBall()
    {
        if(!IsBallMoving)
        {
            selfRigidbody.AddForce(new Vector3(BallForce * BallDirectionHorizontal, gameObject.transform.position.y, BallForce * BallDirectionVertical), ForceMode.VelocityChange);
            IsBallMoving = true;
        }
    }


    //Play this function every 5 seconde
    //Check if ball did not touch a Rune for like 5 seconde
/*    void RandomBall()
    {
        if(RandomBallB == true)
        {
            MoveBallShack();
        }
        else
        {
            RandomBallB = true;
        }
    }
    */
   /* public void MoveBallShack()
    {
        selfRigidbody.AddForce(new Vector3(BallForce * BallDirection, gameObject.transform.position.y, -BallForce), ForceMode.VelocityChange);
    }*/
}