using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StartSequenceOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SequenceAction : ActOnDialogueEvent.Action
		{
			public Transform actor;
			public Transform otherParticipant;
			[MultilineAttribute]
			public string sequence;
		}

		public SequenceAction[] onStart;
		public SequenceAction[] onEnd;
	}
}
