using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	[SerializeField]
	Vector3 BirdSpeed = new Vector3(1, 0, 0);
	private void OnCollisionEnter2D(Collision2D collision) {
		if(collision.collider.tag == "BirdWall") {
			BirdSpeed = -BirdSpeed;
		}
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Nest") {
			CheckWin.HasWon = true;
		}

	}
	private void Update() {
		transform.position += BirdSpeed*Time.deltaTime;
		transform.rotation = Quaternion.identity;
		transform.position = new Vector3 (transform.position.x, -3.63f, transform.position.z);
	}
}
