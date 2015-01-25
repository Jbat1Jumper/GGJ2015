using UnityEngine;
using System.Collections;

public class SeguirEnanos : MonoBehaviour {

	public Vector3 Offset = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Enano1.IsDead)
						return;
		var enanos = Object.FindObjectsOfType<Enano1> ();
		if (enanos.Length == 0)
			return;
		var posProm = new Vector3(0,0,0);
		var i = 1;
		foreach (var enano in enanos) {
			var diff = enano.transform.position - posProm;
			posProm += diff / i;
			i++;
		}
		this.transform.position += new Vector3(((posProm - this.transform.position) + Offset).x * 0.1F, 0F);

	}
}
