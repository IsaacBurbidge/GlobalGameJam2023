using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision) {
		if(collision.collider.tag == "Nest") {
			CheckWin.HasWon = true;
		}
	}
}
