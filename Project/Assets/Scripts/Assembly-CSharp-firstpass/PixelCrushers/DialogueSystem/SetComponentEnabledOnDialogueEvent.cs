using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetComponentEnabledOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetComponentEnabledAction : ActOnDialogueEvent.Action
		{
			public Component target;
			public Toggle state;
		}

		public SetComponentEnabledAction[] onStart;
		public bool waitOneFrameOnStart;
		public SetComponentEnabledAction[] onEnd;
		public bool waitOneFrameOnEnd;
	}
}
