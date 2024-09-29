using System;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIQTEControls : AbstractUIQTEControls
	{
		public UnityUIQTEControls(Graphic[] qteIndicators)
		{
		}

		public Graphic[] qteIndicators;
	}
}
