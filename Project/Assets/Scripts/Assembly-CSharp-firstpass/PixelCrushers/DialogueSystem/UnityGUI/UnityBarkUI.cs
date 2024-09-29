using PixelCrushers.DialogueSystem;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class UnityBarkUI : AbstractBarkUI
	{
		public Transform textPosition;
		public GUISkin guiSkin;
		public string guiStyleName;
		public bool includeName;
		public float duration;
		public float fadeDuration;
		public TextStyle textStyle;
		public Color textStyleColor;
		public BarkSubtitleSetting textDisplaySetting;
		public bool waitUntilSequenceEnds;
		public bool checkIfPlayerVisible;
		public LayerMask visibilityLayerMask;
	}
}
