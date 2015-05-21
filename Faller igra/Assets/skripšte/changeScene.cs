using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour
{
    public GameObject UI;
    void Start()
    {
        UI.SetActive(true);


    }
    public Transform prefab;
    public void ChangeToScene(bool vrednsot)
    {
        UI.SetActive(vrednsot);
        PlayerM.down = -100;
        PlayerM.truecan = true;


    }


 

}
