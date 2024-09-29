using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[Serializable]
	public class GUIImageParams
	{
		public Rect pixelRect;
		public Texture2D texture;
		public bool useTexCoords;
		public Rect texCoords;
		public ScaleMode scaleMode;
		public bool alphaBlend;
		public Color color;
		public float aspect;
	}
}
