using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class LuaScriptWizardAttribute : PropertyAttribute
	{
		public LuaScriptWizardAttribute(bool showReferenceDatabase)
		{
		}

		public bool showReferenceDatabase;
	}
}
