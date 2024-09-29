using System;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class ScaledRect
	{
		public ScaledRectAlignment origin;
		public ScaledRectAlignment alignment;
		public ScaledValue x;
		public ScaledValue y;
		public ScaledValue width;
		public ScaledValue height;
		public float minPixelWidth;
		public float minPixelHeight;
	}
}
