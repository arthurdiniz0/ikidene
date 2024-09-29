using UnityEngine;
using System;

namespace PixelCrushers.DialogueSystem
{
	public class ActOnDialogueEvent : MonoBehaviour
	{
		[Serializable]
		public class Action
		{
			public Condition condition;
		}

		public DialogueEvent trigger;
		public bool once;
		public DialogueDatabase selectedDatabase;
	}
}
