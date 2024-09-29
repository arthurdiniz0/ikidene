using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class AutoSize
	{
		public bool autoSizeWidth;
		public bool autoSizeHeight;
		public ScaledValue maxWidth;
		public ScaledValue maxHeight;
		public RectOffset padding;
	}
}
