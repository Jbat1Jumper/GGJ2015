using UnityEngine;
using System.Collections;

public class PausaParaUnClick : MonoBehaviour {

	private bool Llego = false;
	private bool Termino = false;
	private Object DedoSenalador = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Llego && !Termino && Input.GetMouseButtonDown (0)) {
			Debug.Log ("Click tutorial?");
			var mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mp.z = 0;
			Debug.Log(mp.ToString() + " - - - " + ((mp - this.transform.position).magnitude).ToString());
			if((mp - this.transform.position).magnitude < 0.5F) {
				Termino = true;
				PlaySound();
				Time.timeScale = 1.0F;

				var ce = Object.FindObjectOfType<ControladorEnanos>();
				ce.ClickSobreEnanos();

				Destroy(DedoSenalador);
				Destroy(this.gameObject);
			}
		}	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.GetComponent<Enano1> () == null) {
			Debug.Log("No es un enano, solo puedo pausar enanos");
			return;
		}
		if (Llego) {
			Debug.Log ("Ya han pasado enanos por aqui");
			return;
		}

		Llego = true;
		Time.timeScale = 0F;
		DedoSenalador = Object.Instantiate (Resources.Load ("DedoSenalador"), this.transform.position, Quaternion.identity);
	}

	void PlaySound() {
		Debug.Log ("Click");
	}
}
