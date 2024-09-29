using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIBarkUI : AbstractBarkUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
		}

		public CanvasGroup canvasGroup;
		public Text barkText;
		public Text nameText;
		public bool includeName;
		public float doneTime;
		public AnimationTransitions animationTransitions;
		public float duration;
		public bool waitUntilSequenceEnds;
		public bool waitForContinueButton;
		public BarkSubtitleSetting textDisplaySetting;
	}
}
