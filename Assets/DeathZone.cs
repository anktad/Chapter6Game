using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {
	public static bool dead;

	// Use this for initialization
	void Start () {
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Hiyoko") {
			UiController.gameOver = true;
			dead = true;
		}
	}
}