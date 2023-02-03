using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{
	public Player inputActions;
	
	public static void SetInput(GameObject Player,Player inputActions) {
		Player.GetComponent<Growing>().inputActions = inputActions;
	}

	private void OnCollisionStay2D(Collision2D collision) {
		if (collision.collider.tag == "CanGrow") {
			if (inputActions.PlayerControls.Root.IsPressed()) {
				PlayerController.CanMove = false;
			}
		}
	}
}
