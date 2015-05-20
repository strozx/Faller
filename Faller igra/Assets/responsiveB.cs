using UnityEngine;
using System.Collections;

public class responsiveB : MonoBehaviour {
	public GUISkin gSkin;
    GUIStyle ms = new GUIStyle(GUI.skin.button);
	public GUIStyle gs;

	int hs1 =0;
    void Start()
    {
		hs1 = PlayerPrefs.GetInt ("hs1", 0);


    }
	void OnGUI()
	{
		if (death.smrt) {
			//skrito.slika.SetActive(true);
			if (GUI.Button (new Rect ((Screen.width / 2.5f) - (Screen.width * 0.1f), (Screen.height / 2) - (Screen.height * 0.05f), Screen.width * 0.4f, Screen.height * 0.1f), "<size=50>Replay</size>" )) {
				

				Application.LoadLevel ("level");
				death.smrt=false;
				//skrito.slika.SetActive(false);

			}
			GUI.Label (new Rect ((Screen.width / 2.5f) - (Screen.width * 0.1f), (Screen.height / 1.6f) - (Screen.height * 0.05f), Screen.width * 0.4f, Screen.height * 0.1f), "Your score:" + score.hs,gs);
		}
	if (hs1 > score.hs) {
	PlayerPrefs.SetInt ("hs1", score.hs);
			}
	}
}
