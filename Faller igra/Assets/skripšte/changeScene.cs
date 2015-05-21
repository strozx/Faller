using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour
{
    public GameObject UI;
    public GameObject UIr;
 //   public GameObject target;
    void Start()
    {
        UI.SetActive(true);


    }
    
    public void ChangeToScene(bool vrednsot)
    {
        UI.SetActive(vrednsot);
        PlayerM.down = -100;
        PlayerM.truecan = true;


    }
 //   public GameObject BallPrefab;
    //public void replay(bool vrednsot)
    //{
    //    //    UIr.SetActiveRecursively(false);
    //    //    death.smrt = false;
    //    //    gen gen = gameObject.GetComponent<gen>();

    //    //    int down = -100;
    //    //    Instantiate(BallPrefab, Vector3(0, 0, 0), Quaternion.identity);
    //    //    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, down));
    //    //    gen.Start();

    //}


    

   


 

}
