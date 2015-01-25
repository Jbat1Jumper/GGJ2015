using UnityEngine;
using System.Collections;

public class DebugMovimientoEnanos : MonoBehaviour {
	public bool Direction = true;

	public bool Toggle = false;
	public bool ToggleOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Toggle && ToggleOn) {
			MoverEnanos ();
		}
	}

	void OnMouseDown() {
		ToggleOn = !ToggleOn;
	}

	void OnMouseDrag() {
		MoverEnanos ();
	}

	void MoverEnanos() {
		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach (var enano in enanos) {
			if(Direction)
				enano.GoRight(13);
			else
				enano.GoLeft(13);
		}

	}
}
