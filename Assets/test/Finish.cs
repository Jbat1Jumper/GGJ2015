using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("OnTriggerEnter");
		if (other.gameObject.GetComponent<Enano1> () == null) {
			Debug.Log("No es un enano");
			return; // No es un enano
		}
		PlaySound ();
		
		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach (var enano in enanos) 
			enano.DieBy ("Win");
	}
	
	void PlaySound() {
		Debug.Log ("Cheers");
	}
}
