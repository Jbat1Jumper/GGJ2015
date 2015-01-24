using UnityEngine;
using System.Collections;

public class Enano1 : MonoBehaviour {

	public int NumeroEnano = 0;

	public float Impulso = 510; // funciona bien para escala de gravedad 2
	// private float Impulso = 350; // funciona bien para escala de  gravedad 1

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A))
						GoLeft ();
		if (Input.GetKey (KeyCode.D))
						GoRight ();

		FuerzaDeAtraccionEnana ();
	}

	void FuerzaDeAtraccionEnana() {
		var enanos = Object.FindObjectsOfType<Enano1> ();
		foreach (var enano in enanos) {
			if(enano == this) continue;
			enano.transform.position += new Vector3((this.transform.position - enano.transform.position).x * 0.3F, 0F);
		}
	}

	private float speedLimit = 15;

	public void GoLeft(){
		//this.rigidbody2D.AddForce(new Vector3 (-1400 * this.rigidbody2D.mass * Time.deltaTime, 0));
		this.transform.position += new Vector3 (-10 * Time.deltaTime, 0);

		var ev = this.rigidbody2D.velocity;
		if(ev.x < -speedLimit) {
			ev.x = -speedLimit;
			this.rigidbody2D.velocity = ev;
		}
	}
	public void GoRight() {
		//this.rigidbody2D.AddForce(new Vector3 (1400 * this.rigidbody2D.mass * Time.deltaTime, 0));
		this.transform.position += new Vector3 (10 * Time.deltaTime, 0);
		var ev = this.rigidbody2D.velocity;
		if(ev.x > speedLimit) {
			ev.x = speedLimit;
			this.rigidbody2D.velocity = ev;
		}
	}

	bool HasEnanoUp()
	{
		var rch = Physics2D.Raycast (new Vector2 (this.transform.position.x, 
		                                		  this.transform.position.y + 0.01F), 
		                   			 new Vector2 (0, 1), 
		                             0.10F);
		if (rch) {
			var enanoInterior = rch.transform.gameObject.GetComponent<Enano1>();
			if(enanoInterior != null)
				return true;
		}
		rch = Physics2D.Raycast (new Vector2 (this.transform.position.x + this.collider2D.bounds.size.x, 
		                                          this.transform.position.y + 0.01F), 
		                             new Vector2 (0, 1), 
		                             0.10F);
		if (rch) {
			var enanoInterior = rch.transform.gameObject.GetComponent<Enano1>();
			if(enanoInterior != null)
				return true;
		}
		return false;
	}

	bool IsGrounded()
	{
		return Physics2D.Raycast (new Vector2 (this.transform.position.x, 
		                                     this.transform.position.y - this.collider2D.bounds.size.y - 0.01F), 
		                         new Vector2 (0, -1), 
		                         0.10F)
			|| Physics2D.Raycast (new Vector2 (this.transform.position.x + this.collider2D.bounds.size.x / 2, 
			                                 this.transform.position.y - this.collider2D.bounds.size.y - 0.01F), 
			                     new Vector2 (0, -1), 
			                     0.15F)
			|| Physics2D.Raycast (new Vector2 (this.transform.position.x + this.collider2D.bounds.size.x, 
				                                 this.transform.position.y - this.collider2D.bounds.size.y - 0.01F), 
				                     new Vector2 (0, -1), 
				                     0.10F);
	}

	void Subir() 
	{
		if (!IsGrounded ()) {
			return;
		}
		this.rigidbody2D.AddForce (new Vector3 (0, Impulso, 0));
		var ev = this.rigidbody2D.velocity;
		if(ev.y > 1) {
			ev.y = 1;
			this.rigidbody2D.velocity = ev;
		}

		if (!HasEnanoUp ())
			return;

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
			return;
		}

		var abajo = FindEnanoByNum (NumeroEnano - 1);

		Subir ();
		if (abajo != null)
			abajo.Bajar ();
	}
}
