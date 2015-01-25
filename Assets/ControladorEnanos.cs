using UnityEngine;
using System.Collections;

public class ControladorEnanos : MonoBehaviour {

	public float WalkingSpeed = 13;

	private float TiempoDeGracia = 1.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (TiempoDeGracia > 0) {
			TiempoDeGracia -= Time.deltaTime;
			return;
		}

		var enanos = Object.FindObjectsOfType<Enano1> ();
		
		foreach (var enano in enanos) {
			enano.GoRight(WalkingSpeed);
		}

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Pressed");
			var mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log ("On " + mp.ToString());
			mp.z = 0;
			Enano1 ganador = null;
			var ganador_dist = 1000000F;
			foreach (var enano in enanos) {
				var ep = enano.transform.position;
				var ex = enano.collider2D.bounds.extents;
				ex.y *= -1;
				ep = ep + ex;
				var distance = (mp - ep).magnitude;
				if(distance > enano.collider2D.bounds.size.x * 1.4F)
					continue;
				if(!enano.IsGrounded())
					continue;
				if(ganador_dist > distance) {
					ganador_dist = distance;
					ganador = enano;
				}
			}
			if(ganador != null) {
				ganador.Click();
			}
		}
	}
}
