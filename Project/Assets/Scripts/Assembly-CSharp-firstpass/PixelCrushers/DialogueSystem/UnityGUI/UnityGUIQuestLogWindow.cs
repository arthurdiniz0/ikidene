using PixelCrushers.DialogueSystem;
using System;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	public class UnityGUIQuestLogWindow : QuestLogWindow
	{
		[Serializable]
		public class AbandonControls
		{
			public GUIControl panel;
			public GUILabel questTitleLabel;
			public GUIButton ok;
			public GUIButton cancel;
		}

		public GUIRoot guiRoot;
		public GUIScrollView scrollView;
		public GUIButton activeButton;
		public GUIButton completedButton;
		public AbandonControls abandonQuestPopup;
		public string groupHeadingGuiStyleName;
		public string questHeadingGuiStyleName;
		public string questHeadingOpenGuiStyleName;
		public string questBodyGuiStyleName;
		public string questEntryActiveGuiStyleName;
		public string questEntrySuccessGuiStyleName;
		public string questEntryFailureGuiStyleName;
		public string questEntryButtonStyleName;
		public string noQuestsGuiStyleName;
		public int padding;
	}
}
