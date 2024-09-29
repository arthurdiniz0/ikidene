using System;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIResponseMenuControls : AbstractUIResponseMenuControls
	{
		public Graphic panel;
		public Image pcImage;
		public Text pcName;
		public UnityUISubtitleControls subtitleReminder;
		public Slider timer;
		public bool selectCurrentOnTimeout;
		public UnityUIResponseButton[] buttons;
		public UnityUIResponseButton buttonTemplate;
		public Graphic buttonTemplateHolder;
		public Scrollbar buttonTemplateScrollbar;
		public float buttonTemplateScrollbarResetValue;
		public bool explicitNavigationForTemplateButtons;
		public bool loopExplicitNavigation;
		public UIAutonumberSettings autonumber;
		public UIAnimationTransitions animationTransitions;
		public UnityEvent onContentChanged;
		public List<GameObject> instantiatedButtons;
	}
}
