using UnityEngine;
using System.Collections;

public class oblaki_gen : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 100; i++) {
			for (s=0; s < 2; s++) {
				spawnO ();
			}
			st--;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	int st= 11;
	int s = 0;
	
	
	private void spawnO()
	{				
		
		Vector3 posO = transform.position;
		Vector3 pos2O = transform.position;
		float screenRatioO = (float)Screen.width / (float)Screen.height;
		float widthOrthoO = Camera.main.orthographicSize * screenRatioO;
		posO.x = 1.5f+(widthOrthoO);
		pos2O.x = (-widthOrthoO)-1.5f;
		float randomPosO = Random.Range (posO.x, pos2O.x);
		int randO = Random.Range (11, 15);
		string randSO = System.Convert.ToString (randO);
		if(Physics.CheckSphere(new Vector3(randomPosO,st) , 1.5f))
		{
			randomPosO = Random.Range (posO.x, pos2O.x);
			
		}
		Instantiate(plat_gen.tipPlatO[randSO], new Vector3 ((randomPosO), st, 5), Quaternion.identity);
		
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		
		
		if (screenPosition.y < Screen.height){
			Destroy(this.gameObject);
		}
		
		
		
	}
	
}


















