using UnityEngine;
using System.Collections;

public class movment : MonoBehaviour {
	float down=100f;
	// Use this for initialization

		
		// Use this for initialization
		void Start () {
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, down));
		}
	}
	
