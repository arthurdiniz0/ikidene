using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class QuestTrigger : DialogueEventStarter
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;
			public string message;
			public string parameter;
		}

		public DialogueTriggerEvent trigger;
		public Condition condition;
		public string questName;
		public bool setQuestState;
		public QuestState questState;
		public bool setQuestEntryState;
		public int questEntryNumber;
		public QuestState questEntryState;
		public string luaCode;
		public string alertMessage;
		public LocalizedTextTable localizedTextTable;
		public SendMessageAction[] sendMessages;
		public bool useQuestNamePicker;
		public DialogueDatabase selectedDatabase;
	}
}
