using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class Navigation
	{
		public bool enabled;
		public bool focusFirstControlOnEnable;
		public bool jumpToMousePosition;
		public GUIControl[] order;
		public string clickButton;
		public KeyCode click;
		public KeyCode previous;
		public KeyCode next;
		public string axis;
		public bool invertAxis;
		public float axisRepeatDelay;
		public float mouseWheelSensitivity;
	}
}
