using UnityEngine;
using System.Collections;

public class Enano1 : MonoBehaviour {

	public int NumeroEnano = 0;

	private float Impulso = 510; // funciona bien para escala de gravedad 2
	// private float Impulso = 350; // funciona bien para escala de  gravedad 1

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (IsGrounded ())
			Debug.Log (NumeroEnano + " IsGrounded");

		if (Input.GetKey (KeyCode.A))
						GoLeft ();
		if (Input.GetKey (KeyCode.D))
						GoRight ();
	}

	void GoLeft(){
		this.rigidbody2D.AddForce(new Vector3 (-20, 0));
	}
	void GoRight() {
		this.rigidbody2D.AddForce(new Vector3 (20, 0));
	}

	bool IsGrounded()
	{
		return Physics2D.Raycast(new Vector2(this.transform.position.x + this.collider2D.bounds.size.x / 2, 
		                                     this.transform.position.y - this.collider2D.bounds.size.y - 0.01F), 
		                         new Vector2(0, -1), 
		                         0.08F);
	}

	void Subir() 
	{
		if (!IsGrounded ()) {
			Debug.Log ("No puedo subir");
			return;
		}
		this.rigidbody2D.AddForce (new Vector3 (0, Impulso, 0));
		var ev = this.rigidbody2D.velocity;
		if(ev.y > 1) {
			ev.y = 1;
			this.rigidbody2D.velocity = ev;
		}
		
		var arriba = FindEnanoByNum (NumeroEnano + 1);
		if(arriba != null)
			arriba.Subir ();
	}

	void Bajar()
	{
		this.rigidbody2D.AddForce (new Vector3 (0, -Impulso * 0.3F, 0));
		var ev = this.rigidbody2D.velocity;
		if (ev.y > 1) {
			ev.y = 1;
			this.rigidbody2D.velocity = ev;
		}
		if (IsGrounded ()) {
			Debug.Log ("Empujo al de abajo");
			var abajo = FindEnanoByNum (NumeroEnano - 1);
			if(abajo != null)
				abajo.Bajar ();
		}
	}

	Enano1 FindEnanoByNum(int num) 
	{
		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach (var enano in enanos) {
			if(enano.NumeroEnano == num)
				return enano;
		}
		return null;
	}

	void OnMouseDown() {
		 
		if (!IsGrounded ()) {
			Debug.Log ("No puedo saltar");
			return;
		}

		var abajo = FindEnanoByNum (NumeroEnano - 1);

		Subir ();
		if (abajo != null)
			abajo.Bajar ();
	}
}
