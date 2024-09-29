using UnityEngine;

namespace Cinemachine
{
	public class CinemachineClearShot : CinemachineVirtualCameraBase
	{
		public Transform m_LookAt;
		public Transform m_Follow;
		public bool m_ShowDebugText;
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;
		public float m_ActivateAfter;
		public float m_MinDuration;
		public bool m_RandomizeChoice;
		public CinemachineBlendDefinition m_DefaultBlend;
		public CinemachineBlenderSettings m_CustomBlends;
	}
}
