using UnityEngine;
using System.Collections;

public class gumbki : MonoBehaviour {

	// Use this for initialization
	public void replayScene (string sceneToChangeTo)
	{
		Application.LoadLevel (sceneToChangeTo);
		
	}
	
}
