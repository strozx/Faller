using UnityEngine;
using System.Collections;

public class pofU : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public GameObject zoga;
	public GameObject UIr;
	public static bool konec=false;
	// Update is called once per frame
	void FixedUpdate () {
                Touch t = Input.GetTouch(0);
 if (t.phase == TouchPhase.Ended)
        {

               

                    UIr.SetActiveRecursively(true);
 
				Destroy(this.gameObject);
        }
	}
}
