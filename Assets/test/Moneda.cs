using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {
	
	public int Valor = 1;
	
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

		var scores = Object.FindObjectsOfType<Score> ();
		foreach (var score in scores)
			score.IncrementScore (Valor);


		Destroy(this.gameObject);
	}
	
	void PlaySound() {
		Debug.Log ("Tilin");
	}
}
