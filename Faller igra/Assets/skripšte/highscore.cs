using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
	public static int score =0;
	// Use this for initialization
	void Start () {
        score = PlayerPrefs.GetInt("hs1", 0);
        GetComponent<Text>().text = "High Score: " + score;
        
	}
	
	// Update is called once per frame
	void Update () {
		
      
	}

  
}
