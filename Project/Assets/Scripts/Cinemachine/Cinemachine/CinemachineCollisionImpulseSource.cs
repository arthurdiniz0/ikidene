using UnityEngine;

namespace Cinemachine
{
	public class CinemachineCollisionImpulseSource : CinemachineImpulseSource
	{
		public LayerMask m_LayerMask;
		public string m_IgnoreTag;
		public bool m_UseImpactDirection;
		public bool m_ScaleImpactWithMass;
		public bool m_ScaleImpactWithSpeed;
	}
}
