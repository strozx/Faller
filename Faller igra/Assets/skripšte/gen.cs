using UnityEngine;
using System.Collections;

public class gen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    public void zacetek()
    {
        st = platform.transform.position.y;
        for (int i = 0; i < 30; i++)
        {
            for (s = 0; s < 1; s++)
            {
                spawn();
            }
            st= st-2;
        }
        plat_delte_spawn.dobST = true;
        plat_delte_spawn.st1 = st;
    }
    public GameObject platform;
	public static float st=0;
	int s = 0;

	public void spawn()
	{
       
			Vector3 pos = transform.position;
			Vector3 pos2 = transform.position;
			float screenRatio = (float)Screen.width / (float)Screen.height;
			float widthOrtho = Camera.main.orthographicSize * screenRatio;
				pos.x = 1.5f+(widthOrtho);
		pos2.x = (-widthOrtho)-1.5f;
			float randomPos = Random.Range (pos.x, pos2.x);
        
				int rand = Random.Range (1, 6);
			string randS = System.Convert.ToString (rand);
			Instantiate (plat_generation.tipPlat [randS], new Vector3 ((randomPos), st, 0), Quaternion.identity);
			Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);


		if (screenPosition.y < Screen.height){
			Destroy(this.gameObject);
						}
}


}


















