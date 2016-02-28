﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiController : MonoBehaviour {

	public Text text;
	public static bool gameOver;
	public GameObject button;


	// Use this for initialization
	void Start () {
		text.enabled = false;
		button.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver){
			text.enabled = true;
			button.SetActive (true);
		}
	}
}