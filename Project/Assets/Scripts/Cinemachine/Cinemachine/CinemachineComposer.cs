using UnityEngine;

namespace Cinemachine
{
	public class CinemachineComposer : CinemachineComponentBase
	{
		public Vector3 m_TrackedObjectOffset;
		public float m_LookaheadTime;
		public float m_LookaheadSmoothing;
		public bool m_LookaheadIgnoreY;
		public float m_HorizontalDamping;
		public float m_VerticalDamping;
		public float m_ScreenX;
		public float m_ScreenY;
		public float m_DeadZoneWidth;
		public float m_DeadZoneHeight;
		public float m_SoftZoneWidth;
		public float m_SoftZoneHeight;
		public float m_BiasX;
		public float m_BiasY;
	}
}
