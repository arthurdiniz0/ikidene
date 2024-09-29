using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineFreeLook : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Orbit
		{
			public Orbit(float h, float r) : this()
			{
			}

			public float m_Height;
			public float m_Radius;
		}

		public Transform m_LookAt;
		public Transform m_Follow;
		public bool m_CommonLens;
		public LensSettings m_Lens;
		public CinemachineVirtualCameraBase.TransitionParams m_Transitions;
		[SerializeField]
		private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint;
		public AxisState m_YAxis;
		public AxisState.Recentering m_YAxisRecentering;
		public AxisState m_XAxis;
		public CinemachineOrbitalTransposer.Heading m_Heading;
		public AxisState.Recentering m_RecenterToTargetHeading;
		public CinemachineTransposer.BindingMode m_BindingMode;
		public float m_SplineCurvature;
		public Orbit[] m_Orbits;
		[SerializeField]
		private float m_LegacyHeadingBias;
		[SerializeField]
		private CinemachineVirtualCamera[] m_Rigs;
	}
}
