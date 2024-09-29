using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class EmphasisSetting
	{
		public EmphasisSetting(string colorCode, string styleCode)
		{
		}

		public Color color;
		public bool bold;
		public bool italic;
		public bool underline;
	}
}
