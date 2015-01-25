using UnityEngine;
using System.Collections;

public class MusicBox : MonoBehaviour {

	void Awake () {
		GameObject mb = GameObject.Find("MusicBox");
		if (mb != null)
			Destroy (this.gameObject);
		
		DontDestroyOnLoad(gameObject);
	}

	public static MusicBox GetInstance() {
		return Object.FindObjectOfType<MusicBox> ();
	}
}
