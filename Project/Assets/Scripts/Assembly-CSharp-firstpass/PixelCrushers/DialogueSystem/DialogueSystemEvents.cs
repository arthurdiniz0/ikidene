using UnityEngine;
using System;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class DialogueSystemEvents : MonoBehaviour
	{
		[Serializable]
		public class TransformEvent : UnityEvent<Transform>
		{
		}

		[Serializable]
		public class SubtitleEvent : UnityEvent<Subtitle>
		{
		}

		[Serializable]
		public class ResponsesEvent : UnityEvent<Response[]>
		{
		}

		[Serializable]
		public class ConversationEvents
		{
			public DialogueSystemEvents.TransformEvent onConversationStart;
			public DialogueSystemEvents.TransformEvent onConversationEnd;
			public DialogueSystemEvents.TransformEvent onConversationCancelled;
			public DialogueSystemEvents.SubtitleEvent onConversationLine;
			public DialogueSystemEvents.SubtitleEvent onConversationLineEnd;
			public DialogueSystemEvents.SubtitleEvent onConversationLineCancelled;
			public DialogueSystemEvents.ResponsesEvent onConversationResponseMenu;
			public UnityEvent onConversationResponseMenuTimeout;
			public DialogueSystemEvents.TransformEvent onLinkedConversationStart;
		}

		[Serializable]
		public class BarkEvents
		{
			public DialogueSystemEvents.TransformEvent onBarkStart;
			public DialogueSystemEvents.TransformEvent onBarkEnd;
			public DialogueSystemEvents.SubtitleEvent onBarkLine;
		}

		[Serializable]
		public class SequenceEvents
		{
			public DialogueSystemEvents.TransformEvent onSequenceStart;
			public DialogueSystemEvents.TransformEvent onSequenceEnd;
		}

		[Serializable]
		public class StringEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class QuestEvents
		{
			public DialogueSystemEvents.StringEvent onQuestStateChange;
			public DialogueSystemEvents.StringEvent onQuestTrackingEnabled;
			public DialogueSystemEvents.StringEvent onQuestTrackingDisabled;
			public UnityEvent onUpdateQuestTracker;
		}

		[Serializable]
		public class PauseEvents
		{
			public UnityEvent onDialogueSystemPause;
			public UnityEvent onDialogueSystemUnpause;
		}

		public ConversationEvents conversationEvents;
		public BarkEvents barkEvents;
		public SequenceEvents sequenceEvents;
		public QuestEvents questEvents;
		public PauseEvents pauseEvents;
	}
}
