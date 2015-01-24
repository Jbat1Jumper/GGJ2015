using UnityEngine;
using System.Collections;

public class DebugMovimientoEnanos : MonoBehaviour {
	public bool Direction = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDrag() {
		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach (var enano in enanos) {
			if(Direction)
				enano.GoRight();
			else
				enano.GoLeft();
		}
	}
}
