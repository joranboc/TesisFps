using UnityEngine;
using System.Collections;

public class Shooted : MonoBehaviour {

	public bool shooted = false;
	// Use this for initialization
	public GameObject manager;
	LataManager ScriptManager;
	void Start () {
		ScriptManager = manager.GetComponent<LataManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter (Collision col){
		if(col.gameObject.CompareTag("Wood") || col.gameObject.CompareTag("Metal") ){
			
		}else{
			if(shooted == false){
			shooted = true;
				ScriptManager.disparada();
			
			}
		}
	}
}
