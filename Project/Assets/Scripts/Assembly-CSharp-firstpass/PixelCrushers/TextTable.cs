using UnityEngine;
using System.Collections.Generic;

namespace PixelCrushers
{
	public class TextTable : ScriptableObject
	{
		[SerializeField]
		private List<string> m_languageKeys;
		[SerializeField]
		private List<int> m_languageValues;
		[SerializeField]
		private List<int> m_fieldKeys;
		[SerializeField]
		private List<TextTableField> m_fieldValues;
		[SerializeField]
		private int m_nextLanguageID;
		[SerializeField]
		private int m_nextFieldID;
	}
}
