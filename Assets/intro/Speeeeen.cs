using UnityEngine;
using System.Collections;

public class Speeeeen : MonoBehaviour {

	public float Speed = 10.0F;

	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (0, 0, 1), Speed * Time.deltaTime);
	}
}
