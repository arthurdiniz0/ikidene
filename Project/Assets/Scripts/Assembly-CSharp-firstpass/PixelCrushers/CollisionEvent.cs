using UnityEngine;

namespace PixelCrushers
{
	public class CollisionEvent : TagMaskEvent
	{
		[SerializeField]
		private GameObjectUnityEvent m_onCollisionEnter;
		[SerializeField]
		private GameObjectUnityEvent m_onCollisionExit;
	}
}
