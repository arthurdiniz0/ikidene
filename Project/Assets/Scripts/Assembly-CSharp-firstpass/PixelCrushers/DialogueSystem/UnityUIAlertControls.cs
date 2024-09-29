using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIAlertControls : AbstractUIAlertControls
	{
		public Graphic panel;
		public Text line;
		public Button continueButton;
		public bool queueAlerts;
		public bool waitForHideAnimation;
		public UIAnimationTransitions animationTransitions;
	}
}
