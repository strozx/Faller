using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
	public static int score =0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		score = PlayerPrefs.GetInt ("hs1", 0);
        GetComponent<Text>().text = "High Score: " + score;
	}

  
}
