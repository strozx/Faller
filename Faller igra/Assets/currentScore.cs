using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class currentScore : MonoBehaviour {
    public static int score1 = 0;
	// Use this for initialization
	void Start () {
        score1 = score.hs;
        GetComponent<Text>().text = "Current score: " + score1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
