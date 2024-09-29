using UnityEngine;
using System;
using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class LocalizedTextTable : ScriptableObject
	{
		[Serializable]
		public class LocalizedTextField
		{
			public string name;
			public List<string> values;
		}

		public List<string> languages;
		public List<LocalizedTextTable.LocalizedTextField> fields;
	}
}
