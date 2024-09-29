using PixelCrushers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUISubtitlePanel : UIPanel
	{
		public RectTransform panel;
		public Image portraitImage;
		public UITextField portraitName;
		public UITextField subtitleText;
		public bool addSpeakerName;
		public string addSpeakerNameFormat;
		public bool accumulateText;
		public Button continueButton;
		public UIVisibility visibility;
		public string focusAnimationTrigger;
		public string unfocusAnimationTrigger;
		public bool useAnimatedPortraits;
		public bool onlyShowNPCPortraits;
		public UnityEvent onFocus;
		public UnityEvent onUnfocus;
	}
}
