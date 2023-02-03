using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int PlayerSpeed = 5;
	[SerializeField]
    
    void Update(){
        
    }

    void MoveRight() {
        transform.position += new Vector3(PlayerSpeed* Time.deltaTime, 0,0);
	}
    void MoveLeft() {
        transform.position += new Vector3(-PlayerSpeed*Time.deltaTime, 0, 0);
    }
}
