using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LuaConditionsWizardAttribute : PropertyAttribute
	{
		public LuaConditionsWizardAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
