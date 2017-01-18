using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;

	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z);
	}
}
