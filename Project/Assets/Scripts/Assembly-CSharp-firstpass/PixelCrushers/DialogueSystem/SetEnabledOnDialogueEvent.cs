using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetEnabledOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetEnabledAction : ActOnDialogueEvent.Action
		{
			public MonoBehaviour target;
			public Toggle state;
		}

		public SetEnabledAction[] onStart;
		public bool waitOneFrameOnStart;
		public SetEnabledAction[] onEnd;
		public bool waitOneFrameOnEnd;
	}
}
