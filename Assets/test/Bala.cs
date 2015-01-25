using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public float Velocidad = -10;
	public Vector3 Direccion = new Vector3(1, 0, 0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += Direccion * (Velocidad * Time.deltaTime);
	}
}
