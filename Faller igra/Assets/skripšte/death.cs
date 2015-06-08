using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {
    public GameObject replayCan;

	public static bool smrt = false;
    void Start()
    {
        hs1 = PlayerPrefs.GetInt("hs1", 0);


    }

    public static int hs1 = 0;
	void OnTriggerEnter2D(Collider2D other)
	{
        
		smrt = true;
		Destroy (this.gameObject);
        PlayerM.touch = false;
        replayCan.SetActiveRecursively(true);
        if (hs1 < score.hs)
        {
            PlayerPrefs.SetInt("hs1", score.hs);
        }
	}
    void Update()
    {
      

//        if (hs1 > score.hs)
//        {
//            PlayerPrefs.SetInt("hs1", score.hs);
//        }
    }



}
