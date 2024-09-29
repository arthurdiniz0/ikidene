using UnityEngine;

namespace PixelCrushers
{
	public class TriggerEvent : TagMaskEvent
	{
		[SerializeField]
		private GameObjectUnityEvent m_onTriggerEnter;
		[SerializeField]
		private GameObjectUnityEvent m_onTriggerExit;
	}
}
