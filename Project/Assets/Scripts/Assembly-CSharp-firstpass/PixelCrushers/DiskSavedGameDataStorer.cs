using UnityEngine;

namespace PixelCrushers
{
	public class DiskSavedGameDataStorer : SavedGameDataStorer
	{
		public bool encrypt;
		public string encryptionPassword;
		[SerializeField]
		private bool m_debug;
	}
}
