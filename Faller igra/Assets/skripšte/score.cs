using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public static int hs=0;
	Vector3 _lastPosition;
    public static Vector3 _firstPosition;
	// Use this for initialization
	void Start () {
		_lastPosition = this.transform.position;
		hs = 0;
        _firstPosition = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if( ( this.transform.position.y - _lastPosition.y ) < _firstPosition.y ){
			hs++;
			
			_lastPosition = this.transform.position;
		}
	}
}
