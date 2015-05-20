using UnityEngine;
using System.Collections;

public class checkPosition : MonoBehaviour {

    void Start ()
    {
        //GetComponent<Collider>().isTrigger = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player" || other.tag == "plat")
        {
        Destroy(gameObject);
        }
    }
}
