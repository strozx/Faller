using UnityEngine;
using System.Collections;

public class oblak_deltespawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public static bool dobST = false;
    void OnTriggerEnter2D(Collider2D other)
    {



        for (int i = 0; i < 2; i++)
        {
            spawnN();
        }
        st1--;


    }

 float st1 = -101;
    Vector3 center;

    public void spawnN()
    {

        Vector3 pos = transform.position;
        Vector3 pos2 = transform.position;
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        pos.x = 1.5f + (widthOrtho);
        pos2.x = (-widthOrtho) - 1.5f;
        float randomPos = Random.Range(pos.x, pos2.x);
        center.Set(randomPos, st1, 0f);
        //  Collider[] hitColliders = Physics.OverlapSphere(center, 7f);



        //foreach (Collider col in hitColliders)
        //{
        // //   if (col.GetComponent<Rigidbody2D>())
        //   // {
        //        randomPos = Random.Range(pos.x, pos2.x);
        //    //}
        //}

        int rand = Random.Range(11,15);
        string randS = System.Convert.ToString(rand);

        Instantiate(plat_gen.tipPlatO[randS], new Vector3((randomPos), st1, 0), Quaternion.identity);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);


    }
}
