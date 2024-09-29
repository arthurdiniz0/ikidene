using UnityEngine;

namespace PixelCrushers
{
	public class PlayerPrefsSavedGameDataStorer : SavedGameDataStorer
	{
		[SerializeField]
		private string m_playerPrefsKeyBase;
		public bool encrypt;
		public string encryptionPassword;
		[SerializeField]
		private bool m_debug;
	}
}
