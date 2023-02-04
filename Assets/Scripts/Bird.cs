using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	[SerializeField]
	Vector3 BirdSpeed = new Vector3(1, 0, 0);
	[SerializeField]
	Vector3 BirdVector;
	private void Start() {
		BirdVector = BirdSpeed;
	}
	private void OnCollisionEnter2D(Collision2D collision) {
		if(collision.collider.tag == "BirdWall") {
			BirdSpeed = -BirdSpeed;
			BirdVector = BirdSpeed;
			GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
		}
		if (collision.collider.tag == "Stairs") {
			BirdVector += new Vector3(0, 0.1f, 0);
			
		}
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.tag == "Nest") {
			CheckWin.HasWon = true;
		}
	}
	private void OnCollisionExit2D(Collision2D collision) {
		if (collision.collider.tag == "Stairs") {
			BirdVector = BirdSpeed;
		}
	}
	private void Update() {
		transform.position += BirdVector * Time.deltaTime;
		transform.rotation = Quaternion.identity;
	}
}
