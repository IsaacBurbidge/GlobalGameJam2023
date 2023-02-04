using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public int PlayerSpeed = 5;
    public int JumpHeight = 4;
	private Player inputActions;
    public static bool CanMove = true;
    public Vector3 GrowScale;
    private void Start() {
        GetComponent<PlayerController>().inputActions = new Player();
        GetComponent<PlayerController>().inputActions.Enable();
        Growing.SetInput(this.transform.gameObject,inputActions);
    }
    void Update(){
		switch (CanMove) {
            case true: {
                if (inputActions.PlayerControls.Right.IsPressed()) {
                    MoveRight();
                } else if (inputActions.PlayerControls.Left.IsPressed()) {
                    MoveLeft();
                } 

				break;
            }
            case false: {
                if (inputActions.PlayerControls.Grow.IsPressed()) {
                    Grow();
                }
                break;
            }
        }
		if (inputActions.PlayerControls.Jump.IsPressed()) {
            Debug.Log("hi");
			Jump();
		}
	}
    void MoveRight() {
        transform.position += new Vector3(PlayerSpeed* Time.deltaTime, 0,0);
	}
    void MoveLeft() {
        transform.position += new Vector3(-PlayerSpeed*Time.deltaTime, 0, 0);
    }
    void Jump() {
		transform.position += new Vector3(0, JumpHeight, 0);
	}
    void Grow() {
		transform.localScale = GrowScale;
	}
    void UnRoot() {
        transform.localScale = new Vector3(1, 1, 1);
	}
}
