using UnityEngine;
using System.Collections;

public class TouchSwipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 deltaPos = Input.GetTouch (0).deltaPosition / 100.0f;

		Vector3 pos = transform.localPosition;
		pos.x = pos.x - deltaPos.x;
		pos.y = pos.y - deltaPos.y;

		transform.localPosition = pos;
	}
}
