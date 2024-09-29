using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineImpulseManager
	{
		[Serializable]
		public struct EnvelopeDefinition
		{
			public AnimationCurve m_AttackShape;
			public AnimationCurve m_DecayShape;
			public float m_AttackTime;
			public float m_SustainTime;
			public float m_DecayTime;
			public bool m_ScaleWithImpact;
			public bool m_HoldForever;
		}

		public class ImpulseEvent
		{
			public enum DissipationMode
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2,
			}

			public enum DirectionMode
			{
				Fixed = 0,
				RotateTowardSource = 1,
			}

			public float m_StartTime;
			public CinemachineImpulseManager.EnvelopeDefinition m_Envelope;
			public Vector3 m_Position;
			public float m_Radius;
			public DirectionMode m_DirectionMode;
			public int m_Channel;
			public DissipationMode m_DissipationMode;
			public float m_DissipationDistance;
		}

		private CinemachineImpulseManager()
		{
		}

	}
}
