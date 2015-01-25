using UnityEngine;
using System.Collections;

public class GoToScene : MonoBehaviour {

	public string Destination = "";

	public void GoTo() {
		Application.LoadLevel (Destination);
	}

	void OnMouseDown() {
		GoTo ();
	}
}
