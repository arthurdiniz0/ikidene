using System;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UIAnimationTransitions
	{
		public string showTrigger;
		public string hideTrigger;
		public UIShowHideController.TransitionMode transitionMode;
		public bool debug;
	}
}
