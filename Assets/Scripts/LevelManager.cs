using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public void OnSandbox() {
		SceneManager.LoadScene(1);
	}
	public void OnLevel(int Index) {
		SceneManager.LoadScene(Index + 4);
	}
}
