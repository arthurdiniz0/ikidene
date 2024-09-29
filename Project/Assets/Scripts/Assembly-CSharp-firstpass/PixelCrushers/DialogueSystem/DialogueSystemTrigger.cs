using UnityEngine;
using System;
using PixelCrushers;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemTrigger : MonoBehaviour
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;
			public string message;
			public string parameter;
		}

		[Serializable]
		public class SetGameObjectActiveAction
		{
			public Condition condition;
			public Transform target;
			public Toggle state;
		}

		[Serializable]
		public class SetComponentEnabledAction
		{
			public Condition condition;
			public Component target;
			public Toggle state;
		}

		[Serializable]
		public class SetAnimatorStateAction
		{
			public Condition condition;
			public Transform target;
			public string stateName;
			public float crossFadeDuration;
		}

		public enum BarkSource
		{
			None = 0,
			Conversation = 1,
			Text = 2,
		}

		public DialogueSystemTriggerEvent trigger;
		public Condition condition;
		public bool setQuestState;
		public string questName;
		public QuestState questState;
		public bool setQuestEntryState;
		public int questEntryNumber;
		public QuestState questEntryState;
		public string luaCode;
		[TextAreaAttribute]
		public string sequence;
		public Transform sequenceSpeaker;
		public Transform sequenceListener;
		public bool waitOneFrameOnStartOrEnable;
		public string alertMessage;
		public TextTable textTable;
		public float alertDuration;
		public SendMessageAction[] sendMessages;
		public BarkSource barkSource;
		public string barkConversation;
		public string barkText;
		public string barkTextSequence;
		public Transform barker;
		public Transform barkTarget;
		public BarkOrder barkOrder;
		public bool allowBarksDuringConversations;
		public bool skipBarkIfNoValidEntries;
		public bool cacheBarkLines;
		public string conversation;
		public Transform conversationConversant;
		public Transform conversationActor;
		public bool exclusive;
		public bool skipIfNoValidEntries;
		public bool stopConversationOnTriggerExit;
		public bool stopConversationIfTooFar;
		public float maxConversationDistance;
		public float monitorConversationDistanceFrequency;
		public bool showCursorDuringConversation;
		public bool pauseGameDuringConversation;
		public SetGameObjectActiveAction[] setActiveActions;
		public SetComponentEnabledAction[] setEnabledActions;
		public SetAnimatorStateAction[] setAnimatorStateActions;
		public GameObjectUnityEvent onExecute;
		public bool useConversationTitlePicker;
		public bool useBarkTitlePicker;
		public bool useQuestNamePicker;
		public DialogueDatabase selectedDatabase;
	}
}
