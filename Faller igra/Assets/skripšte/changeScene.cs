using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour
{
    public GameObject UI;
    public GameObject UIr;
    void Start()
    {
        UI.SetActive(true);

        if (zacetniM)
        {
            UI.SetActiveRecursively(false);
            zacetniM = false;
            PlayerM.truecan = true;
            zacetek();
            
        }


    }
    
    public void ChangeToScene(bool vrednost)// ta funkcija se ne izvede včeri do 10:34 se je izvedla pol je pa nehal delat
    {
       this.UI.SetActiveRecursively(vrednost); 
        PlayerM.down = -100;
        PlayerM.truecan = true;
        score._firstPosition = this.transform.position;
        PlayerM.touch = true;
       

    }
    public void back()
    {
        Application.LoadLevel("level");

    }
    public static bool zacetniM = false;
    public void replay(bool vrednsot)
    {
        UIr.SetActive(false);
        Application.LoadLevel("level");
        UI.SetActiveRecursively(false);
            zacetniM= true;
            PlayerM.touch = true;
    }
    public void spawn()
    {

        Vector3 pos = transform.position;
        Vector3 pos2 = transform.position;
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        pos.x = 1.5f + (widthOrtho);
        pos2.x = (-widthOrtho) - 1.5f;
        float randomPos = Random.Range(pos.x, pos2.x);
        int rand = Random.Range(1, 6);
        string randS = System.Convert.ToString(rand);

        Instantiate(plat_generation.tipPlat[randS], new Vector3((randomPos), st, 0), Quaternion.identity);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);


        if (screenPosition.y < Screen.height)
        {
            Destroy(this.gameObject);
        }
    }
    public void zacetek()
    {
        st = platform.transform.position.y;
        for (int i = 0; i < 30; i++)
        {
            for (s = 0; s < 2; s++)
            {
                spawn();
            }
            st=st-2;
        }

    }
    public GameObject platform;
    float st = 0;
    int s = 0;
    float st1 = -98;
    int s1 = 0;
    //public void zac()
    //{
    //    for (int i = 0; i < 200; i++)
    //    {
    //        for (s1 = 0; s1 < 2; s1++)
    //        {
    //            spawnO();
    //        }
    //        st1--;
    //    }

    //}

    //private void spawnO()
    //{

    //    Vector3 posO = transform.position;
    //    Vector3 pos2O = transform.position;
    //    float screenRatioO = (float)Screen.width / (float)Screen.height;
    //    float widthOrthoO = Camera.main.orthographicSize * screenRatioO;
    //    posO.x = 1.5f + (widthOrthoO);
    //    pos2O.x = (-widthOrthoO) - 1.5f;
    //    float randomPosO = Random.Range(posO.x, pos2O.x);
    //    int randO = Random.Range(11, 15);
    //    string randSO = System.Convert.ToString(randO);
    //    if (Physics.CheckSphere(new Vector3(randomPosO, st1), 1.5f))
    //    {
    //        randomPosO = Random.Range(posO.x, pos2O.x);

    //    }
    //    Instantiate(plat_gen.tipPlatO[randSO], new Vector3((randomPosO), st1, 5), Quaternion.identity);

    //    Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);


    //    if (screenPosition.y < Screen.height)
    //    {
    //        Destroy(this.gameObject);
    //    }



    //}

}
