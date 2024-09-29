using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SendMessageOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SendMessageAction : ActOnDialogueEvent.Action
		{
			public Transform target;
			public string methodName;
			public string parameter;
		}

		public SendMessageAction[] onStart;
		public SendMessageAction[] onEnd;
	}
}
