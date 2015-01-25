using UnityEngine;
using System.Collections;

public class SeguirCamara2 : MonoBehaviour {
	
	private Vector3 Offset;

	// Use this for initialization
	void Start () {
		var c = Camera.main;
		Offset = this.transform.position - c.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		var c = Camera.main;
		this.transform.position = c.transform.position + Offset;
	}
}
