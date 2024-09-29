using System;
using UnityEngine.UI;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class UnityUIQuestLogWindow : QuestLogWindow
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;
			public string hideTrigger;
			public UIShowHideController.TransitionMode transitionMode;
			public bool debug;
		}

		public Graphic mainPanel;
		public Button activeQuestsButton;
		public Button completedQuestsButton;
		public Graphic questTable;
		public UnityUIQuestGroupTemplate questGroupTemplate;
		public UnityUIQuestTemplate questTemplate;
		public Graphic abandonPopup;
		public Text abandonQuestTitle;
		public AnimationTransitions animationTransitions;
		public bool autoFocus;
		public float autoFocusCheckFrequency;
		public UnityEvent onOpen;
		public UnityEvent onClose;
		public UnityEvent onContentChanged;
		public bool addEventSystemIfNeeded;
	}
}
