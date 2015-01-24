using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("OnTriggerEnter");
		if (other.gameObject.GetComponent<Enano1> () == null) {
			Debug.Log("No es un enano");
			return; // No es un enano
		}
		PlaySound ();

		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach(var enano in enanos) 
			Destroy(enano.gameObject);

		Object.Instantiate (Resources.Load ("RestartPanel"));
	}
	
	void PlaySound() {
		Debug.Log ("Die");
	}
}
