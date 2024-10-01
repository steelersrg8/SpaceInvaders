using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NewMonoBehaviour : MonoBehaviour
{ 
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        //Collision with a Ship? Then, destroy it.

        if (coll.gameObject.tag == "Ship")
        {
            Destroy(coll.gameObject);
            SceneManager.LoadScene(0);
        }
        Destroy(gameObject);
    }
}
