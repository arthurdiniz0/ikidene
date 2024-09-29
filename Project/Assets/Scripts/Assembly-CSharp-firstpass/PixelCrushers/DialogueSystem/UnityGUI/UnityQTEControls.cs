using System;
using PixelCrushers.DialogueSystem;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class UnityQTEControls : AbstractUIQTEControls
	{
		public UnityQTEControls(GUIControl[] qteIndicators)
		{
		}

		public GUIControl[] qteIndicators;
	}
}
