using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnBackButtonPressed()
	{
		// add code here to handle the back button press
		Application.LoadLevel("PreviousScreen");
	}

	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			OnBackButtonPressed();
				}

	}
}
