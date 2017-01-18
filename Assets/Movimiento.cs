using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	public float velocidad;

	[SerializeField]
	private float floatSpeed = 0.2f;
	// Use this for initialization
	private float startingY;
	private bool isMovingUp = true;
	[SerializeField]
	private float movementDistance = 2.5f; 

	void Start () {
	
		startingY = transform.position.y;
		StartCoroutine (Float ());

	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}

	private IEnumerator Float()
	{
		while (true)
		{
			float newY = transform.position.y + (isMovingUp ? 1 : -1) * 2 * movementDistance * floatSpeed * Time.deltaTime;

			if (newY > startingY + movementDistance)
			{
				newY = startingY + movementDistance;
				isMovingUp = false;
			}
			else if (newY < startingY)
			{
				newY = startingY;
				isMovingUp = true;
			}

			transform.position = new Vector3(transform.position.x, newY, transform.position.z);
			yield return 0;
		}
	}
}