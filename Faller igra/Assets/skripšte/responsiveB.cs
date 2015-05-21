using UnityEngine;
using System.Collections;

public class responsiveB : MonoBehaviour {
  
	int hs1 =0;
    void Start()
    {
		hs1 = PlayerPrefs.GetInt ("hs1", 0);


    }
	void Update()
	{
		if (death.smrt) {

            replayCan.SetActive(true);

			}
			
	if (hs1 > score.hs) {
	PlayerPrefs.SetInt ("hs1", score.hs);
			}
	}
}
