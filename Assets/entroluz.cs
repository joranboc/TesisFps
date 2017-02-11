using UnityEngine;
using System.Collections;

public class entroluz : MonoBehaviour {
	public GameObject manager;
	nivelManager ScriptManager;
	// Use this for initialization
	void Start(){
		ScriptManager = manager.GetComponent<nivelManager>();
	}
	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")){
		ScriptManager.desactivar1();
	}
}
}
