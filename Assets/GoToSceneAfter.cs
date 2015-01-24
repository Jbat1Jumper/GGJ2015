using UnityEngine;
using System.Collections;

public class GoToSceneAfter : MonoBehaviour {
	
	public float Seconds = 4F;
	public string Destination = "";

	private float ElapsedSeconds = 0F;
	// Use this for initialization
	void Start () {
		ElapsedSeconds = 0F;
	}
	
	// Update is called once per frame
	void Update () {
		ElapsedSeconds += Time.deltaTime;
		 
		if(ElapsedSeconds >= Seconds)
			Application.LoadLevel (Destination);
	}
}
