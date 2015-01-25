using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	public float Velocidad = -10;
	public Vector3 Direccion = new Vector3(1, 0, 0);
	public bool EsperarUnTrigger = false;

	// Use this for initialization
	void Start () {
	
	}

	public void Fire() {
		EsperarUnTrigger = false;
	}

	// Update is called once per frame
	void Update () {
		if(!EsperarUnTrigger)
			this.transform.position += Direccion * (Velocidad * Time.deltaTime);
	}
}
