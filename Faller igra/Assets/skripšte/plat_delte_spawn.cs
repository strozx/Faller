using UnityEngine;
using System.Collections;

public class plat_delte_spawn : MonoBehaviour {

	// Use this for initialization

		
		
		
		void Start() {


		}
	public static float st1= 0;
    int stPozicO = -98;
	void Update()
	{
    
        if(stO >= 1)
        {

            for (int i = 0; i < 3; i++)
            {
                spawnO();
            }
            stPozicO = stPozicO - 2;
            stO = 0;
        }
		}
    int stO = 0;
   public static bool dobST = false;
	void OnTriggerEnter2D(Collider2D other)
	{
        
                for (int i = 0; i < 3; i++)
                {
				spawnN();
              
                }
			st1= st1 -3;

            stO++; 
		}
			

    Vector2 center;

	public void spawnN()
	{				
		
		Vector3 pos = transform.position;
		Vector3 pos2 = transform.position;
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;
		pos.x = 1.5f+(widthOrtho);
		pos2.x = (-widthOrtho)-1.5f;
		float randomPos = Random.Range (pos.x, pos2.x);
        center.Set(randomPos, st1);
     
     //  if(Physics2D.OverlapCircle(center,4f))
        //{
          //  randomPos = Random.Range(pos.x, pos2.x);
            //center.Set(randomPos, st1);

        //}
		int rand = Random.Range (1, 6);
		string randS = System.Convert.ToString (rand);
		
		Instantiate (plat_generation.tipPlat [randS], new Vector3 ((randomPos), st1, 0), Quaternion.identity);
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		
		

		
		
	}
    public void spawnO()
    {

        Vector3 posO = transform.position;
        Vector3 pos2O = transform.position;
        float screenRatioO = (float)Screen.width / (float)Screen.height;
        float widthOrthoO = Camera.main.orthographicSize * screenRatioO;
        posO.x = 1.5f + (widthOrthoO);
        pos2O.x = (-widthOrthoO) - 1.5f;
        float randomPosO = Random.Range(posO.x, pos2O.x);
        int randO = Random.Range(11, 15);
        string randSO = System.Convert.ToString(randO);
        //if (Physics.CheckSphere(new Vector3(randomPosO, stPozicO), 1.5f))
        //{
        //    randomPosO = Random.Range(posO.x, pos2O.x);

        //}
        Instantiate(plat_gen.tipPlatO[randSO], new Vector3((randomPosO), stPozicO, 5), Quaternion.identity);

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);


        if (screenPosition.y < Screen.height)
        {
            Destroy(this.gameObject);
        }
		

    }
}
