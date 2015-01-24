using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int CurrentScore = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore(int by) {
		CurrentScore += by;
		var tm = this.GetComponent<TextMesh> ();
		if(tm != null)
			tm.text = "Score: " + CurrentScore;
	}
}
