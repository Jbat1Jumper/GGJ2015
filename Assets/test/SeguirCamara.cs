using UnityEngine;
using System.Collections;

public class SeguirCamara : MonoBehaviour {
	
	public Vector3 Offset = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var c = Camera.main;
		if (this.transform == null)
						Debug.Log ("ES NULL");
		var a = (c.transform.position - this.transform.position);
		var b = a + Offset;
		this.transform.position += (b) * Time.deltaTime;
	}
}
