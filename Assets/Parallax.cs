using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

	private Vector3 OriginalPos;
	private Vector3 OriginalScale;

	// Use this for initialization
	void Start () {
		OriginalPos = this.transform.position;
		OriginalScale = this.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		var c = Camera.main;
		var cpos = c.transform.position;

		var coff = OriginalPos - cpos;
		var p = cpos + coff / (1 + OriginalPos.z / 10);
		this.transform.position = new Vector3 (p.x, p.y, OriginalPos.z);
		this.transform.localScale = OriginalScale / (1 + OriginalPos.z / 10);
	}
}
