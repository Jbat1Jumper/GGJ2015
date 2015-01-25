using UnityEngine;
using System.Collections;

public class CameraLight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Object.Instantiate (Resources.Load ("CameraLight"), this.transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
