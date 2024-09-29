using System;
using PixelCrushers;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUsableUI : AbstractUsableUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
		}

		public UITextField nameText;
		public UITextField useMessageText;
		public Color inRangeColor;
		public Color outOfRangeColor;
		public Graphic reticleInRange;
		public Graphic reticleOutOfRange;
		public AnimationTransitions animationTransitions;
		public Canvas canvas;
	}
}
