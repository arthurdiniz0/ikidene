using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationPopupAttribute : PropertyAttribute
	{
		public ConversationPopupAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
