using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class plat_gen : MonoBehaviour {
	
	public GameObject[] plat_prefbO;
	public static Dictionary<String, GameObject> tipPlatO;
	
	
	
	// Use this for initialization
	void Start () {
		tipPlatO = new Dictionary<String, GameObject >();
		
		foreach (GameObject prefabO in plat_prefbO) {
			
			tipPlatO[prefabO.name]=prefabO;
			
		}
	}
	
	
}
