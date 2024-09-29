using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetActiveOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetActiveAction : ActOnDialogueEvent.Action
		{
			public Transform target;
			public Toggle state;
		}

		public SetActiveAction[] onStart;
		public SetActiveAction[] onEnd;
	}
}
