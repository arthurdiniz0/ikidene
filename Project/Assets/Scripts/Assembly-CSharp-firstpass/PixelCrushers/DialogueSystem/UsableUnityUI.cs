using System;
using UnityEngine.UI;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class UsableUnityUI : AbstractUsableUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
		}

		public Text nameText;
		public Text useMessageText;
		public Color inRangeColor;
		public Color outOfRangeColor;
		public Graphic reticleInRange;
		public Graphic reticleOutOfRange;
		public AnimationTransitions animationTransitions;
	}
}
