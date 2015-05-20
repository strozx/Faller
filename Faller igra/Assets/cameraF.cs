using UnityEngine;
using System.Collections;

public class cameraF : MonoBehaviour {

	public Transform target;
			
			float offsetY;
			
			// Use this for initialization
			void Start () {
				GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
				Screen.orientation = ScreenOrientation.Portrait;
				target = playerObj.transform;
				offsetY = transform.position.y - target.position.y;
				
			}
			
			// Update is called once per frame
			void Update () {
				Vector3 pos = transform.position;
				pos.y = target.position.y - (offsetY/2);
				transform.position = pos;
				
				
				
			}
	}
