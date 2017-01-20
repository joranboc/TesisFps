using UnityEngine;
using System.Collections;

public class FinalNivel : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			Debug.Log("Felicidades terminaste el tutorial");
		
		}
	}
}
