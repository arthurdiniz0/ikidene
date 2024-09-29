using UnityEngine;
using System;
using UnityEngine.UI;
using PixelCrushers;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUISelectorElements : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
		}

		public Graphic mainGraphic;
		public UITextField nameText;
		public UITextField useMessageText;
		public Color inRangeColor;
		public Color outOfRangeColor;
		public Graphic reticleInRange;
		public Graphic reticleOutOfRange;
		public AnimationTransitions animationTransitions;
	}
}
