using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel (Application.loadedLevelName);
	}

	void OnMouseDown() {
		Application.LoadLevel (Application.loadedLevelName);
	}
}
