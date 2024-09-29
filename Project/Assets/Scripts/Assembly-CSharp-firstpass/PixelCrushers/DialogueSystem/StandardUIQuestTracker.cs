using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class StandardUIQuestTracker : MonoBehaviour
	{
		public enum QuestDescriptionSource
		{
			Title = 0,
			Description = 1,
		}

		public string playerPrefsToggleKey;
		public Transform container;
		public bool showContainerIfEmpty;
		public StandardUIQuestTrackTemplate questTrackTemplate;
		public bool showActiveQuests;
		public bool showCompletedQuests;
		public bool showCompletedEntryText;
		public QuestDescriptionSource questDescriptionSource;
		public bool visibleOnStart;
	}
}
