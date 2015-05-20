using UnityEngine;
using System.Collections;

public class highscore : MonoBehaviour {
	int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetInt ("hs1", 0);
	}

	void OnGUI()
	{
		GUI.Label (new Rect ((Screen.width / 3.2f) - (Screen.width * 0.1f), (Screen.height / 1.5f) - (Screen.height * 0.1f), Screen.width * 0.6f, Screen.height * 0.2f), "<size=30>High score:"+ score+"</size>");
		}
}
