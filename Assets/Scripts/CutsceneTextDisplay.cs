using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTextDisplay : MonoBehaviour
{
	Camera cam;
	Vector3 boxPosition;
	float boxW = 150f;
	float boxH = 20f;
	public string Text = "Player One";
	public GUISkin guiSkin;
	public float offsetX = 0;
	public float offsetY = 0.5f;
	public int fontSize = 20;
	public Color color = new Color(50, 50, 50);

	private void Start() {
		cam = GetComponentInParent<Camera>();
	}

	private void OnGUI() {
		GUI.skin = guiSkin;
		boxPosition = Camera.main.WorldToScreenPoint(transform.position);
		boxPosition.y = Screen.height - boxPosition.y;
		boxPosition.x -= boxW * 0.2f;
		boxPosition.y -= boxH * 3.5f;
		guiSkin.box.fontSize = fontSize;

		GUI.contentColor = color;
		Vector2 content = guiSkin.box.CalcSize(new GUIContent(Text));

		GUI.Box(new Rect(boxPosition.x - content.x / 2 * offsetX, boxPosition.y + offsetY, content.x, content.y), Text);
	}
	public static void SetText(string Text, GameObject Player) {
		Player.GetComponent<CutsceneTextDisplay>().Text = Text;
	}
}
