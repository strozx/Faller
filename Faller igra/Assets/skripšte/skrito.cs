using UnityEngine;
using System.Collections;

public class skrito : MonoBehaviour {
	public GameObject slika ;
	// Use this for initialization
	void Start () {
		slika.SetActive (false);
	
	
	}
	
	// Update is called once per frame
	void Update () {
	slika.SetActive(false);
	if (death.smrt) {
			slika.SetActive(true);

				}
	}
}
