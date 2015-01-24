using UnityEngine;
using System.Collections;

public class GoToScene : MonoBehaviour {

	public string Destination = "";

	void OnMouseDown() {
		Application.LoadLevel (Destination);
	}
}
