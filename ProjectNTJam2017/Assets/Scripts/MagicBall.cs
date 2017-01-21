using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{

    private Rigidbody selfRigidbody;
    public int BallForce;
    private int BallDirection;
    private bool IsBallMoving;

    // Use this for initialization
    void Start()
    {
        IsBallMoving = false;
        selfRigidbody = GetComponent<Rigidbody>();
        BallDirection = Random.Range(-1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (BallDirection == 0)
        {
            BallDirection = Random.Range(-1, 2);
        }
        else
        {
            MoveBall();
        }
    }

    public void MoveBall()
    {
        if(!IsBallMoving)
        {
            selfRigidbody.AddForce(new Vector3(BallForce * BallDirection, gameObject.transform.position.y, -BallForce), ForceMode.VelocityChange);
            IsBallMoving = true;
        }
    }
}