using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public KeyCode HotKey = KeyCode.P;
	public bool UseHotKey = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (UseHotKey && Input.GetKeyDown (HotKey)) {
			if(Time.timeScale < 0.1)
				Time.timeScale = 1F;
			else
				Time.timeScale = 0F;
		}
	}
}
