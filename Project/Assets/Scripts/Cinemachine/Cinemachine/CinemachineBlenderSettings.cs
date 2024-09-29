using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	public class CinemachineBlenderSettings : ScriptableObject
	{
		[Serializable]
		public struct CustomBlend
		{
			public string m_From;
			public string m_To;
			public CinemachineBlendDefinition m_Blend;
		}

		public CustomBlend[] m_CustomBlends;
	}
}
