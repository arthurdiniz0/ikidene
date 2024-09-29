using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Instruction
		{
			public int m_FullHash;
			public CinemachineVirtualCameraBase m_VirtualCamera;
			public float m_ActivateAfter;
			public float m_MinDuration;
		}

		[Serializable]
		internal struct ParentHash
		{
			public ParentHash(int h, int p) : this()
			{
			}

			public int m_Hash;
			public int m_ParentHash;
		}

		public Transform m_LookAt;
		public Transform m_Follow;
		public Animator m_AnimatedTarget;
		public int m_LayerIndex;
		public bool m_ShowDebugText;
		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;
		public Instruction[] m_Instructions;
		public CinemachineBlendDefinition m_DefaultBlend;
		public CinemachineBlenderSettings m_CustomBlends;
		[SerializeField]
		internal ParentHash[] m_ParentHash;
	}
}
