using UnityEngine;
using System.Collections;

public class downB : MonoBehaviour {
    public float downb = 0;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, downb));
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
