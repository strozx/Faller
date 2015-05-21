using UnityEngine;
using System.Collections;

public class PlayerM : MonoBehaviour {
	public static float down=-50f;
	public GameObject gumb;
	public GameObject slika;
    public GameObject canvas;
    public static bool truecan = false;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, down));
		gumb.SetActive(false);
		slika.SetActive (false);

	}
	//float velocity=0;
	float shipBoundaryRadius = 0.301f;

	public Transform target;
	// Update is called once per frame
	void Update()
	{
       
		}
	void FixedUpdate () {
		try{

            if (truecan)
            {
                down = -50;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, down));
                truecan = false;
            }

			Vector3 pos = transform.position;




		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;
		
		//horizontal bounds
		if(pos.x+shipBoundaryRadius > widthOrtho) {
			  
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if(pos.x-shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
			
		}

		Touch t = Input.GetTouch(0);
		Vector3 pozicija = new Vector3( Camera.main.ScreenToWorldPoint(t.position).x, target.position.y, Camera.main.nearClipPlane);
		target.transform.position = pozicija;

		}
		catch(UnityException)
		{

				}
		
	}
	
}
