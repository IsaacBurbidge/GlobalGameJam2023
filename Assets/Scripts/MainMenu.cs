using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void OnStartGameClick() {
		SceneManager.LoadScene(3);
	}
	public void OnSettingsClick() {

	}
	public void OnExitClick() {
		Application.Quit();
	}
}
