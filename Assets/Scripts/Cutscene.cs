using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
	public List<string> TextList = new List<string>();
	public int Index = 0;
	public bool IsDisplaying = false;
	private void Start() {
		CutsceneTextDisplay.SetText("",this.gameObject);
		OnIndexChanged();
	}

	public void OnIndexChanged() {
		if (Index == TextList.Count) {
			CutsceneTextDisplay.SetText("", this.gameObject);
			SceneManager.LoadScene(3);
		} else {
			CutsceneTextDisplay.SetText(TextList[Index], this.gameObject);
			Index++;
		}

	}
}
