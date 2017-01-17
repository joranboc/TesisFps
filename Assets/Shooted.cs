using UnityEngine;
using System.Collections;

public class Shooted : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter (Collision col){
		if(col.gameObject.CompareTag("Wood")){
			
		}else{
			Debug.Log("shit me dieron");
		}
	}
}
