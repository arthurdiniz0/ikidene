using UnityEngine;

namespace PixelCrushers
{
	public class UILocalizationManager : MonoBehaviour
	{
		[SerializeField]
		private string m_currentLanguagePlayerPrefsKey;
		[SerializeField]
		private TextTable m_textTable;
	}
}
