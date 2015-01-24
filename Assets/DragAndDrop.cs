using UnityEngine;
using System.Collections;

public class DragAndDrop : MonoBehaviour {

	private Vector3 ScreenPoint;
	private Vector3 Offset;
	void OnMouseDown() {
		ScreenPoint = Camera.main.WorldToScreenPoint (this.transform.position);
		Offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z));
	}

	void OnMouseDrag() {
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z);
		Vector3 curPosition  = Camera.main.ScreenToWorldPoint(curScreenPoint) + Offset;
		transform.position = curPosition;
	}
}
