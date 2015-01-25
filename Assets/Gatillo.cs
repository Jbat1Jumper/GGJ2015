using UnityEngine;
using System.Collections;

public class Gatillo : MonoBehaviour {

	public Bala[] Objetivos = null;
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("OnTriggerEnter");
		if (other.gameObject.GetComponent<Enano1> () == null) {
			Debug.Log("No es un enano, solo los enanos pueden gatillarme");
			return; // No es un enano
		}
		PlaySound ();

		if (Objetivos != null) {
			foreach(var Objetivo in Objetivos)
						Objetivo.Fire ();
		}
	}

	void PlaySound() {
		Debug.Log ("Ups!");
	}
}
