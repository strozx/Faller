using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour
{
    public GameObject UI;
    public GameObject UIr;
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

    public void replay(bool vrednsot)
    {
        UIr.SetActive(vrednsot);
 
        


    }


 

}
