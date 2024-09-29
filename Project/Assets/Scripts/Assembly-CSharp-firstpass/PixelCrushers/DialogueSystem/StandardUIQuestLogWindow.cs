using PixelCrushers;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIQuestLogWindow : QuestLogWindow
	{
		public UIPanel mainPanel;
		public UITextField showingActiveQuestsHeading;
		public UITextField showingCompletedQuestHeading;
		public Button activeQuestsButton;
		public Button completedQuestsButton;
		public RectTransform questSelectionContentContainer;
		public StandardUIFoldoutTemplate questGroupTemplate;
		public StandardUIQuestTitleButtonTemplate activeQuestHeadingTemplate;
		public StandardUIQuestTitleButtonTemplate completedQuestHeadingTemplate;
		public bool showNoQuestsText;
		public bool showDetailsOnSelect;
		public bool keepGroupsExpanded;
		public RectTransform questDetailsContentContainer;
		public StandardUITextTemplate questHeadingTextTemplate;
		public StandardUITextTemplate questDescriptionTextTemplate;
		public StandardUITextTemplate questEntryActiveTextTemplate;
		public StandardUITextTemplate questEntrySuccessTextTemplate;
		public StandardUITextTemplate questEntryFailureTextTemplate;
		public StandardUIButtonTemplate abandonButtonTemplate;
		public UIPanel abandonQuestPanel;
		public UITextField abandonQuestTitleText;
		public UnityEvent onOpen;
		public UnityEvent onClose;
		public bool addEventSystemIfNeeded;
		public string foldoutToSelect;
		public string questTitleToSelect;
	}
}
