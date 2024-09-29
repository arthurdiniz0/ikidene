using UnityEngine;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class GUIButton : GUIVisibleControl
	{
		public bool clickable;
		public GUIImageParams disabled;
		public GUIImageParams normal;
		public GUIImageParams hover;
		public GUIImageParams pressed;
		public AudioClip hoverSound;
		public AudioClip clickSound;
		public InputTrigger trigger;
		public string message;
		public string parameter;
		public Transform target;
	}
}
