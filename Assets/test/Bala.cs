using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public float Velocidad = -10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (Velocidad * 0.1F, 0);
	}
}
