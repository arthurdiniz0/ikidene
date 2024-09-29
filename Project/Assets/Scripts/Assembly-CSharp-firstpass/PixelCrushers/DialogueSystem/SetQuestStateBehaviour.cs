using System;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class SetQuestStateBehaviour : PlayableBehaviour
	{
		public string quest;
		public bool setQuestState;
		public QuestState questState;
		public bool setQuestEntryState;
		public int questEntryNumber;
		public QuestState questEntryState;
	}
}
