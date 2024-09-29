using System;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityDialogueControls : AbstractDialogueUIControls
	{
		public GUIControl panel;
		public UnitySubtitleControls npcSubtitle;
		public UnitySubtitleControls pcSubtitle;
		public UnityResponseMenuControls responseMenu;
	}
}
