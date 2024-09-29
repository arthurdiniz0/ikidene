using UnityEngine;

namespace Cinemachine
{
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
	{
		public Transform m_LookAt;
		public Transform m_Follow;
		public LensSettings m_Lens;
		public CinemachineVirtualCameraBase.TransitionParams m_Transitions;
		[SerializeField]
		private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint;
		[SerializeField]
		private Transform m_ComponentOwner;
	}
}
