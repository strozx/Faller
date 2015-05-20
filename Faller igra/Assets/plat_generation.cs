using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class plat_generation : MonoBehaviour {

	public GameObject[] plat_prefb;
	public static Dictionary<String, GameObject> tipPlat;



	// Use this for initialization
	void Start () {
		tipPlat = new Dictionary<String, GameObject >();

		foreach (GameObject prefab in plat_prefb) {

			tipPlat[prefab.name]=prefab;

				}
	}
	

}
