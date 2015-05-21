using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height)
			Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (gameObject);

	}

}
