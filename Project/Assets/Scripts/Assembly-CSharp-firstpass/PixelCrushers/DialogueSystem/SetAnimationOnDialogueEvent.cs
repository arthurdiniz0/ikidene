using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class SetAnimationOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetAnimationAction : ActOnDialogueEvent.Action
		{
			public Transform target;
			public AnimationClip animationClip;
		}

		public SetAnimationAction[] onStart;
		public SetAnimationAction[] onEnd;
	}
}
