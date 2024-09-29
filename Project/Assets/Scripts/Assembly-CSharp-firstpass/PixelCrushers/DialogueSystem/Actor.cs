using System;
using UnityEngine;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class Actor : Asset
	{
		public Texture2D portrait;
		public List<Texture2D> alternatePortraits;
	}
}
