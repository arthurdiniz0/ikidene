using System;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityAlertControls : AbstractUIAlertControls
	{
		public GUIControl panel;
		public GUILabel line;
		public GUIButton continueButton;
	}
}
