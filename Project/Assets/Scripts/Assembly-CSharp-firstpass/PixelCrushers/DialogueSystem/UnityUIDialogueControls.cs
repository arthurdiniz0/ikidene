using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIDialogueControls : AbstractDialogueUIControls
	{
		public Graphic panel;
		public UIAnimationTransitions animationTransitions;
		public UnityUISubtitleControls npcSubtitle;
		public UnityUISubtitleControls pcSubtitle;
		public UnityUIResponseMenuControls responseMenu;
	}
}
