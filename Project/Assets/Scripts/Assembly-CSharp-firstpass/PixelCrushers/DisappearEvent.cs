using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class DisappearEvent : MonoBehaviour
	{
		public enum EventTrigger
		{
			OnDisable = 0,
			OnDestroy = 1,
		}

		[SerializeField]
		private EventTrigger m_eventTrigger;
		[SerializeField]
		private UnityEvent m_onDisappeared;
	}
}
