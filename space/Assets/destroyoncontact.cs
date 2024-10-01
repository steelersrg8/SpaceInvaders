using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyoncontact : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Ship")
        {
            Destroy(coll.gameObject);

        }
    }
}