using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineOrbitalTransposer : CinemachineTransposer
	{
		[Serializable]
		public struct Heading
		{
			public enum HeadingDefinition
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3,
			}

			public Heading(CinemachineOrbitalTransposer.Heading.HeadingDefinition def, int filterStrength, float bias) : this()
			{
			}

			public HeadingDefinition m_Definition;
			public int m_VelocityFilterStrength;
			public float m_Bias;
		}

		public Heading m_Heading;
		public AxisState.Recentering m_RecenterToTargetHeading;
		public AxisState m_XAxis;
		[SerializeField]
		private float m_LegacyRadius;
		[SerializeField]
		private float m_LegacyHeightOffset;
		[SerializeField]
		private float m_LegacyHeadingBias;
		public bool m_HeadingIsSlave;
	}
}
