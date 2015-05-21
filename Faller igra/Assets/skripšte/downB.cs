using UnityEngine;
using System.Collections;

public class downB : MonoBehaviour {
    public float down = 0;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, down));
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
