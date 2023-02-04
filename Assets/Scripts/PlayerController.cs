using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	GameObject Stair;
    public int PlayerSpeed = 5;
    public int JumpHeight = 4;
	private Player inputActions;
    public static bool Rooted = false;
    public Vector3 GrowScale;
    bool IsJumping = false;
    public Vector3 RootedPosition;
    private void Start() {
        GetComponent<PlayerController>().inputActions = new Player();
        GetComponent<PlayerController>().inputActions.Enable();
    }
    void Update(){
		transform.rotation = Quaternion.identity;

        if (inputActions.PlayerControls.Right.IsPressed()) {
            MoveRight();
        } else if (inputActions.PlayerControls.Left.IsPressed()) {
            MoveLeft();
        } 
        if (!IsJumping) {
			if (inputActions.PlayerControls.Jump.IsPressed()) {
                IsJumping = true;
				Jump();
			}
		}
        if (Rooted) {
            transform.position = RootedPosition;
			if (inputActions.Rooted.Grow.IsPressed()) {
				Grow();
			}
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
		StartCoroutine(WaitToJump());
	}
    IEnumerator WaitToJump() {
        yield return new WaitForSeconds(1);
		IsJumping = false;
	}
    void Grow() {
		transform.localScale = GrowScale;
		RootedPosition = transform.position;
		if (inputActions.PlayerControls.Left.IsPressed()) {
			GrowStairs(false);
		} else if (inputActions.PlayerControls.Right.IsPressed()) {
			GrowStairs(true);
		}
	}
	void GrowStairs(bool IsRight) {
		if (IsRight) {
			Instantiate(Stair, transform.position, Quaternion.identity);
		} else {
			GameObject NewStair = Instantiate(Stair, transform.position, Quaternion.identity);
			NewStair.transform.localScale = new Vector3(-1,1,1);
		}
	}
	private void OnTriggerStay2D(Collider2D collision) {
		if (collision.tag == "CanGrow") {
			if (inputActions.PlayerControls.Root.IsPressed()) {
                RootedPosition = transform.position;
				Rooted = true;
			}
			else if (inputActions.PlayerControls.UnRoot.IsPressed()) {
				UnRoot();
			}
		}
	}
	void UnRoot() {
		Rooted = false;
		transform.localScale = new Vector3(1, 1, 1);
	}
}
