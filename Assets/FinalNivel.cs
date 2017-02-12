using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class FinalNivel : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Player")){
			
			SceneManager.LoadScene(1);
		}
	}
}
