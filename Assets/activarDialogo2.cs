﻿using UnityEngine;
using System.Collections;

public class activarDialogo2 : MonoBehaviour {

	public GameObject manager;
	nivelManager ScriptManager;

	void Start(){
		ScriptManager = manager.GetComponent<nivelManager>();
	}

	void OnTriggerEnter ( Collider col  ){
		if(col.gameObject.tag == "Player"){
			ScriptManager.DesSoldiersF();
		}
	}
}
