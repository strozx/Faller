using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {
    public GameObject replayCan;

	public static bool smrt = false;
    void Start()
    {
        hs1 = PlayerPrefs.GetInt("hs1", 0);


    }

    int hs1 = 0;
	void OnTriggerEnter2D(Collider2D other)
	{
		smrt = true;
		Destroy (this.gameObject);
	}
    void Update()
    {
        if (death.smrt)
        {

            replayCan.SetActive(true);

        }

        if (hs1 > score.hs)
        {
            PlayerPrefs.SetInt("hs1", score.hs);
        }
    }



}
