using UnityEngine;
using System;
using UnityEngine.Events;

namespace Cinemachine
{
	public class CinemachineBrain : MonoBehaviour
	{
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain>
		{
		}

		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
		{
		}

		public enum UpdateMethod
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2,
		}

		public bool m_ShowDebugText;
		public bool m_ShowCameraFrustum;
		public bool m_IgnoreTimeScale;
		public Transform m_WorldUpOverride;
		public UpdateMethod m_UpdateMethod;
		public CinemachineBlendDefinition m_DefaultBlend;
		public CinemachineBlenderSettings m_CustomBlends;
		public BrainEvent m_CameraCutEvent;
		public VcamActivatedEvent m_CameraActivatedEvent;
	}
}
