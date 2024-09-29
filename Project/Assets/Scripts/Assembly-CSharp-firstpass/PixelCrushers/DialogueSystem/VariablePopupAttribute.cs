using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class VariablePopupAttribute : PropertyAttribute
	{
		public VariablePopupAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
