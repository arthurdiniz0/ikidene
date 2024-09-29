using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	public class TimedEvent : MonoBehaviour
	{
		public enum TimingMode
		{
			Seconds = 0,
			Frames = 1,
		}

		[SerializeField]
		private TimingMode m_mode;
		[SerializeField]
		private float m_duration;
		[SerializeField]
		private int m_frames;
		[SerializeField]
		private bool m_activateOnStart;
		[SerializeField]
		private UnityEvent m_onTimeReached;
	}
}
