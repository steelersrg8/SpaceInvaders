using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            GameManager.score++;
        }
        else
        {
            Destroy(this.gameObject);

        }
    }
}
