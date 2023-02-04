using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	[SerializeField]
	Vector3 BirdSpeed = new Vector3(1, 0, 0);
	private void OnCollisionEnter2D(Collision2D collision) {
		if(collision.collider.tag == "Nest") {
			//CheckWin.HasWon = true;
		}else if(collision.collider.tag == "BirdWall") {
			BirdSpeed = -BirdSpeed;
		}
	}
	private void Update() {
		transform.position += BirdSpeed*Time.deltaTime;
		transform.rotation = Quaternion.identity;
		transform.position = new Vector3 (transform.position.x, -3.8f, transform.position.z);
	}
}
