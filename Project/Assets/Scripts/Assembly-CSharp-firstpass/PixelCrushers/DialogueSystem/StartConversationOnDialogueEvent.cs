using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StartConversationOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class ConversationAction : ActOnDialogueEvent.Action
		{
			public Transform speaker;
			public Transform listener;
			public string conversation;
			public bool skipIfNoValidEntries;
		}

		public ConversationAction[] onStart;
		public ConversationAction[] onEnd;
	}
}
