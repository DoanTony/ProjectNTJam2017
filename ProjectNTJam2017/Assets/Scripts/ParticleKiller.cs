using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKiller : MonoBehaviour {

    ParticleSystem ps;
    SphereCollider col;

    // Use this for initialization
    void Start () {
        ps = GetComponent<ParticleSystem>();
        col = GetComponent<SphereCollider>();
    }


    // Update is called once per frame
    void Update () {

        if (ps)
        {
            col.radius = ps.shape.radius;
            if(!ps.IsAlive())
            {

                Destroy(gameObject);

            }

        }

	}
}
