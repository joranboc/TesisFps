//ThirstText.cs by Azuline Studios© All Rights Reserved
using UnityEngine;
using System.Collections;

public class ThirstText : MonoBehaviour {
	//draw Thirst amount on screen
	[HideInInspector]
	public float thirstGui;
	private float oldThirstGui = -512;
	[Tooltip("Color of GUIText.")]
	public Color textColor; 
	[Tooltip("Offset from total screen width to position GUIText.")]
	public float horizontalOffset = 0.0425f;
	[Tooltip("Offset from total screen height to position GUIText.")]
	public float verticalOffset = 0.075f;
	[Tooltip("Scaled GUIText size, relative to screen size.")]
	public float fontScale = 0.032f;
	private GUIText guiTextComponent;
	private float oldWidth;//to track screen size change
	
	void Start(){
		guiTextComponent = GetComponent<GUIText>();
		guiTextComponent.material.color = textColor;
		guiTextComponent.fontSize = Mathf.RoundToInt(Screen.height * fontScale);
		oldThirstGui = -512;
		oldWidth = Screen.width;
	}
	

	
}