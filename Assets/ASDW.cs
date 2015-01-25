using UnityEngine;
using System.Collections;

public class ASDW : MonoBehaviour {

	public float Speed = 10F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A))
			this.transform.position += new Vector3 (-Speed, 0) * Time.fixedDeltaTime;
		if (Input.GetKey (KeyCode.S))
			this.transform.position += new Vector3 (0, -Speed) * Time.fixedDeltaTime;
		if (Input.GetKey (KeyCode.D))
			this.transform.position += new Vector3 (Speed, 0) * Time.fixedDeltaTime;
		if (Input.GetKey (KeyCode.W))
			this.transform.position += new Vector3 (0, Speed) * Time.fixedDeltaTime;
	}
}
