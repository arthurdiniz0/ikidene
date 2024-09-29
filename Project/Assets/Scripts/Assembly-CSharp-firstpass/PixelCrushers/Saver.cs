using UnityEngine;

namespace PixelCrushers
{
	public class Saver : MonoBehaviour
	{
		[SerializeField]
		private string m_key;
		[SerializeField]
		private bool m_appendSaverTypeToKey;
		[SerializeField]
		private bool m_saveAcrossSceneChanges;
	}
}
