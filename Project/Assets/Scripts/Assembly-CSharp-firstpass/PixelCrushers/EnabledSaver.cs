using UnityEngine;

namespace PixelCrushers
{
	public class EnabledSaver : Saver
	{
		[SerializeField]
		private Component m_componentToWatch;
	}
}
