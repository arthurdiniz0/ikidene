using UnityEngine;
using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUISelectorDisplay : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
		}

		public Graphic mainGraphic;
		public Text nameText;
		public Text useMessageText;
		public Color inRangeColor;
		public Color outOfRangeColor;
		public Graphic reticleInRange;
		public Graphic reticleOutOfRange;
		public AnimationTransitions animationTransitions;
	}
}
