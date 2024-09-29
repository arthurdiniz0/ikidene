using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	public struct CinemachineBlendDefinition
	{
		public enum Style
		{
			Cut = 0,
			EaseInOut = 1,
			EaseIn = 2,
			EaseOut = 3,
			HardIn = 4,
			HardOut = 5,
			Linear = 6,
			Custom = 7,
		}

		public CinemachineBlendDefinition(CinemachineBlendDefinition.Style style, float time) : this()
		{
		}

		public Style m_Style;
		public float m_Time;
		public AnimationCurve m_CustomCurve;
	}
}
