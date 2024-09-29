using System;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityResponseMenuControls : AbstractUIResponseMenuControls
	{
		public GUIControl panel;
		public GUILabel pcImage;
		public GUILabel pcName;
		public UnitySubtitleControls subtitleReminder;
		public GUIProgressBar timer;
		public GUIButton[] buttons;
	}
}
