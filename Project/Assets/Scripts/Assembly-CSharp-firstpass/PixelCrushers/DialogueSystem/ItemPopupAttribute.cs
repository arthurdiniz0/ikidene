using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ItemPopupAttribute : PropertyAttribute
	{
		public ItemPopupAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
