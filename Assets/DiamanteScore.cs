using UnityEngine;
using System.Collections;

public class DiamanteScore : MonoBehaviour {

	public int MinimoNDiamantes = 0;

	// Use this for initialization
	void Start () {
		if (Enano1.GetScore () < MinimoNDiamantes)
						Destroy (this.gameObject);
	}
}
