using System;
using PixelCrushers;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StandardUIAlertControls : AbstractUIAlertControls
	{
		public UIPanel panel;
		public UITextField alertText;
		public bool queueAlerts;
		public bool dontQueueDuplicates;
		public bool waitForHideAnimation;
		public bool allowForceImmediate;
	}
}
