using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUISubtitleControls : AbstractUISubtitleControls
	{
		public Graphic panel;
		public Text line;
		public Image portraitImage;
		public Text portraitName;
		public Button continueButton;
		public bool ignorePauseCodes;
		public UIAnimationTransitions animationTransitions;
		public UIVisibility uiVisibility;
	}
}
