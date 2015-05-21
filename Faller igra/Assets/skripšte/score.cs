using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public static int hs=0;
	Vector3 _lastPosition;
	// Use this for initialization
	void Start () {
		_lastPosition = this.transform.position;
		hs = 0;
	}

	// Update is called once per frame
	void Update () {
		if( ( this.transform.position.y - _lastPosition.y ) < -2 ){
			hs++;
			
			_lastPosition = this.transform.position;
		}
	}
}
