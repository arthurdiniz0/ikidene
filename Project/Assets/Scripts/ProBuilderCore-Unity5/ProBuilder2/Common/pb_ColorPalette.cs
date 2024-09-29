using System;
using UnityEngine;
using System.Collections.Generic;

namespace ProBuilder2.Common
{
	[Serializable]
	public class pb_ColorPalette : ScriptableObject
	{
		public Color current;
		public List<Color> colors;
	}
}
