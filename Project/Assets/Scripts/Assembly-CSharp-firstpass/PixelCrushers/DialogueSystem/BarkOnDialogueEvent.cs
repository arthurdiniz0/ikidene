using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class BarkOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class BarkAction : ActOnDialogueEvent.Action
		{
			public Transform speaker;
			public Transform listener;
			public string conversation;
		}

		public BarkAction[] onStart;
		public BarkAction[] onEnd;
		public BarkOrder barkOrder;
	}
}
