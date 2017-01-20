using UnityEngine;
using System.Collections;

public class CuidadoBombas : MonoBehaviour {

	public GameObject manager;
	LataManager ScriptManager;
	void Start () {
		ScriptManager = manager.GetComponent<LataManager>();
	}
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			ScriptManager.Bombas();

		}
	}
}
