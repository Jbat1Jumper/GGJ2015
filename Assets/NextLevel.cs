using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	void OnMouseDown() {
		int LvlNum = int.Parse (Application.loadedLevelName.Substring (3)) + 1;
		Application.LoadLevel ("Lvl" + LvlNum.ToString ());
	}
}
