using UnityEngine;

namespace PixelCrushers
{
	public class SpawnedObject : Saver
	{
		public enum Mode
		{
			OnDisable = 0,
			OnDestroy = 1,
		}

		[SerializeField]
		private Mode m_mode;
	}
}
