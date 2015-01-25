using UnityEngine;
using System.Collections;

public class ErasePlayerPrefs : MonoBehaviour {
	void Start () {
		PlayerPrefs.DeleteAll ();
	}
}
