using UnityEngine;
using System.Collections;

public class colision : MonoBehaviour {
	public GameObject manager;
	LataManager ScriptManager;
	public int puntaje = 0;
	// Use this for initialization
	void Start () {
		ScriptManager = manager.GetComponent<LataManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Aviso (){
		puntaje ++;
		if( puntaje == 5){
			ScriptManager.diana();
		}
	}
}
