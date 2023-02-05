using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckLevelComplete : MonoBehaviour
{
	public static bool HasWon = false;
	void Update(){
		if (HasWon == true) {
			SceneManager.LoadScene(4);
			HasWon = false;
			CheckWin.HasWon = false;
		}
	}
}
