using System;

namespace PixelCrushers.DialogueSystem
{
	public class SetQuestStateOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetQuestStateAction : ActOnDialogueEvent.Action
		{
			public string questName;
			public QuestState questState;
			public string alertMessage;
		}

		public SetQuestStateAction[] onStart;
		public SetQuestStateAction[] onEnd;
	}
}
