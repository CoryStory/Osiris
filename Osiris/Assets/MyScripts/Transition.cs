﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == player){
			SceneManager.LoadScene ("Battle1");
		}
	}
}