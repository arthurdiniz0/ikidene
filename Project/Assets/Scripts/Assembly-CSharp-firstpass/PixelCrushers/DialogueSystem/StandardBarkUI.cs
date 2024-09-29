using System;
using UnityEngine;
using PixelCrushers;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardBarkUI : AbstractBarkUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
		}

		public CanvasGroup canvasGroup;
		public UITextField barkText;
		public UITextField nameText;
		public bool includeName;
		public Image portraitImage;
		public bool showPortraitImage;
		public float doneTime;
		public AnimationTransitions animationTransitions;
		public float duration;
		public bool keepInView;
		public bool waitUntilSequenceEnds;
		public bool waitForContinueButton;
		public BarkSubtitleSetting textDisplaySetting;
	}
}
