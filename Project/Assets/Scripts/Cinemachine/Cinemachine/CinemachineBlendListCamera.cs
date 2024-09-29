using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Instruction
		{
			public CinemachineVirtualCameraBase m_VirtualCamera;
			public float m_Hold;
			public CinemachineBlendDefinition m_Blend;
		}

		public Transform m_LookAt;
		public Transform m_Follow;
		public bool m_ShowDebugText;
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;
		public Instruction[] m_Instructions;
	}
}
