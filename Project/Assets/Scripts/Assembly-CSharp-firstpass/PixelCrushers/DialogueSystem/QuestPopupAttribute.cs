using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class QuestPopupAttribute : PropertyAttribute
	{
		public QuestPopupAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
