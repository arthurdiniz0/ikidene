using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class UIShowHideController
	{
		public enum TransitionMode
		{
			State = 0,
			Trigger = 1,
		}

		public UIShowHideController(GameObject gameObjectToControl, Component panelToControl, UIShowHideController.TransitionMode animationMode, bool debug)
		{
		}

	}
}
