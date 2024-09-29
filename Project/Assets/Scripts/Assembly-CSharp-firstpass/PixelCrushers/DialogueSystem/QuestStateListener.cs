using UnityEngine;
using System;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class QuestStateListener : MonoBehaviour
	{
		[Serializable]
		public class QuestStateIndicatorLevel
		{
			public QuestState questState;
			public Condition condition;
			public int indicatorLevel;
			public UnityEvent onEnterState;
		}

		[Serializable]
		public class QuestEntryStateIndicatorLevel
		{
			public int entryNumber;
			public QuestState questState;
			public Condition condition;
			public int indicatorLevel;
			public UnityEvent onEnterState;
		}

		public string questName;
		public QuestStateIndicatorLevel[] questStateIndicatorLevels;
		public QuestEntryStateIndicatorLevel[] questEntryStateIndicatorLevels;
	}
}
