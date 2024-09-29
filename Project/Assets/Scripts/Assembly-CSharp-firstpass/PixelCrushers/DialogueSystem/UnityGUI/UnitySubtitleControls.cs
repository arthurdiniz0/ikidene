using System;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnitySubtitleControls : AbstractUISubtitleControls
	{
		public GUIControl panel;
		public GUILabel line;
		public GUILabel portraitImage;
		public GUILabel portraitName;
		public GUIButton continueButton;
	}
}
