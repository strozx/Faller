using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

	public static bool smrt = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		smrt = true;
		Destroy (this.gameObject);
	}



}
