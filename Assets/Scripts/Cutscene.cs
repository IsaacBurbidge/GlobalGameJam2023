using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
	public List<string> TextList = new List<string>();
	int Index = 0;
	private void Start() {
		CutsceneTextDisplay.SetText("",this.gameObject);
		TextManager();
	}
	void TextManager() {
		StartCoroutine(TimeToWait(0));
	}
	void ShowText() {
		CutsceneTextDisplay.SetText(TextList[Index], this.gameObject);
		TimeToWait(1);
	}
	IEnumerator TimeToWait(int Time) {
		yield return new WaitForSeconds(Time);
		Index++;
		ShowText();
	}
}
