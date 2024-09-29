using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUISelectorElements : MonoBehaviour
	{
		public Graphic mainGraphic;
		public Text nameText;
		public Text useMessageText;
		public Color inRangeColor;
		public Color outOfRangeColor;
		public Graphic reticleInRange;
		public Graphic reticleOutOfRange;
		public UnityUISelectorDisplay.AnimationTransitions animationTransitions;
	}
}
