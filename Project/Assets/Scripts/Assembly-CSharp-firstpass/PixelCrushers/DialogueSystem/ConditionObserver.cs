using UnityEngine;
using System;
using PixelCrushers;

namespace PixelCrushers.DialogueSystem
{
	public class ConditionObserver : MonoBehaviour
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;
			public string message;
			public string parameter;
		}

		public float frequency;
		public bool once;
		public GameObject observeGameObject;
		public Condition condition;
		public string questName;
		public QuestState questState;
		public string luaCode;
		[TextAreaAttribute]
		public string sequence;
		public string alertMessage;
		public TextTable textTable;
		public SendMessageAction[] sendMessages;
		public bool useQuestNamePicker;
	}
}
