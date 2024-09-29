using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class StringField
	{
		[SerializeField]
		private string m_text;
		[SerializeField]
		private StringAsset m_stringAsset;
		[SerializeField]
		private TextTable m_textTable;
		[SerializeField]
		private int m_textTableFieldID;
	}
}
