using UnityEngine;

namespace Cinemachine
{
	public class CinemachineConfiner : CinemachineExtension
	{
		public enum Mode
		{
			Confine2D = 0,
			Confine3D = 1,
		}

		public Mode m_ConfineMode;
		public Collider m_BoundingVolume;
		public Collider2D m_BoundingShape2D;
		public bool m_ConfineScreenEdges;
		public float m_Damping;
	}
}
