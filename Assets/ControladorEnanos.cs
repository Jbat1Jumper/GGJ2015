using UnityEngine;
using System.Collections;

public class ControladorEnanos : MonoBehaviour {

	public float WalkingSpeed = 13;
	private bool JumpedThisTime = false;

	private float TiempoDeGracia = 1.0F;

	// Use this for initialization
	void Start () {
	
	}
	void LateUpdate() {
		JumpedThisTime = false;
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

		if (Time.timeScale < 0.01F)
						return; // el juego esta en pausa, si dejo seguir haciendo 	
								// acciones sobre los enanos estas se acumulan y luego los enanos salen volando

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("Click?");
			ClickSobreEnanos();
		}
	}

	public void ClickSobreEnanos() {
		if (JumpedThisTime)
						return;
		JumpedThisTime = true;
		Debug.Log ("Pressed");
		var enanos = Object.FindObjectsOfType<Enano1> ();
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
