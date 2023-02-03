using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckWin : MonoBehaviour
{
	public static bool HasWon = false;
 
	private void Update() {
		if(HasWon == true) {
			SceneManager.LoadScene(2);
		}
	}
}
