using UnityEngine;
using PixelCrushers;

namespace PixelCrushers.DialogueSystem
{
	public class QuestLogWindow : MonoBehaviour
	{
		public enum QuestHeadingSource
		{
			Name = 0,
			Description = 1,
		}

		public TextTable textTable;
		public string noActiveQuestsText;
		public string noCompletedQuestsText;
		public bool checkVisibleField;
		public QuestHeadingSource questHeadingSource;
		public QuestState abandonQuestState;
		public bool pauseWhileOpen;
		public bool unlockCursorWhileOpen;
		public bool useGroups;
	}
}
