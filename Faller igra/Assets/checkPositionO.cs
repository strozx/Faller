using UnityEngine;
using System.Collections;

public class checkPositionO : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
//        if (other.tag != "Player" || other.tag == "oblak")
//        {
           Destroy(gameObject);
//        }
    }
}
