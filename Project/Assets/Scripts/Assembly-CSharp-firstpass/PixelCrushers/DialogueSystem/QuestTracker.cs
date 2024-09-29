using UnityEngine;
using PixelCrushers.DialogueSystem.UnityGUI;

namespace PixelCrushers.DialogueSystem
{
	public class QuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1,
		}

		public string playerPrefsToggleKey;
		public ScaledRect rect;
		public GUISkin guiSkin;
		public string TitleStyle;
		public string SuccessTitleStyle;
		public string FailureTitleStyle;
		public string ActiveEntryStyle;
		public string SuccessEntryStyle;
		public string FailureEntryStyle;
		public bool showActiveQuests;
		public bool showCompletedQuests;
		public bool showCompletedEntryText;
		public QuestDescriptionSource questDescriptionSource;
	}
}
