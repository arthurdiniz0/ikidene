using UnityEngine;

namespace PixelCrushers
{
	public class DestructibleSaver : Saver
	{
		public enum Mode
		{
			OnDisable = 0,
			OnDestroy = 1,
		}

		public enum DestroyMode
		{
			Destroy = 0,
			Deactivate = 1,
		}

		[SerializeField]
		private Mode m_mode;
		[SerializeField]
		private DestroyMode m_destroyMode;
		[SerializeField]
		private GameObject m_destroyedVersionPrefab;
	}
}
