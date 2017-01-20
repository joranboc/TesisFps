//ExplosiveObject.cs by Azuline Studios© All Rights Reserved
//set up and detonation of explosive objects
using UnityEngine;
using System.Collections;

public class BarrilTutorial : MonoBehaviour {
	public GameObject manager;
	LataManager ScriptManager;
	void Start () {
		ScriptManager = manager.GetComponent<LataManager>();
	}
	void OnDestroy(){

		ScriptManager.barril();
	}
}