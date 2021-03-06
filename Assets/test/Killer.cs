﻿using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {

	public string Tipo = "revienta";
	
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("OnTriggerEnter");
		if (other.gameObject.GetComponent<Enano1> () == null) {
			Debug.Log("No es un enano");
			return; // No es un enano
		}
		PlaySound ();

		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach (var enano in enanos) 
			enano.DieBy (Tipo);
	}
	
	void PlaySound() {
		Debug.Log ("Die");
	}
}
