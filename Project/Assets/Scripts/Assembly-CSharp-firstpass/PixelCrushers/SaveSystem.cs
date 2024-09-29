using UnityEngine;

namespace PixelCrushers
{
	public class SaveSystem : MonoBehaviour
	{
		[SerializeField]
		private bool m_saveCurrentScene;
		[SerializeField]
		private int m_framesToWaitBeforeApplyData;
		[SerializeField]
		private bool m_debug;
	}
}
