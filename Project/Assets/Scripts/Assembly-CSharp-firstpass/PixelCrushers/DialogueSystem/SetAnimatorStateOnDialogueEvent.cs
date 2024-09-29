using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetAnimatorStateOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetAnimatorStateAction : ActOnDialogueEvent.Action
		{
			public Transform target;
			public string stateName;
			public float crossFadeDuration;
		}

		public SetAnimatorStateAction[] onStart;
		public SetAnimatorStateAction[] onEnd;
	}
}
