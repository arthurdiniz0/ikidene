using System;
using UnityEngine;
using System.Collections.Generic;

namespace PixelCrushers
{
	[Serializable]
	public class TextTableField
	{
		[SerializeField]
		private string m_fieldName;
		[SerializeField]
		private List<int> m_keys;
		[SerializeField]
		private List<string> m_values;
	}
}
