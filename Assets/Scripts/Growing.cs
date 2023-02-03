using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{
	public Player inputActions;
	
	public static void SetInput(GameObject Player,Player inputActions) {
		Player.GetComponent<Growing>().inputActions = inputActions;
	}

	private void OnTriggerStay2D(Collider2D collision) {
		if (collision.tag == "CanGrow") {
			if (inputActions.PlayerControls.Root.IsPressed()) {
				PlayerController.CanMove = false;
			} if (inputActions.PlayerControls.UnRoot.IsPressed()) {
				PlayerController.CanMove = true;
			}
		}
	}
}
