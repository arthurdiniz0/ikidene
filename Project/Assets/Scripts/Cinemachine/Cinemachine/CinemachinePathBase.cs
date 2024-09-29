using UnityEngine;
using System;

namespace Cinemachine
{
	public class CinemachinePathBase : MonoBehaviour
	{
		[Serializable]
		public class Appearance
		{
			public Color pathColor;
			public Color inactivePathColor;
			public float width;
		}

		public enum PositionUnits
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2,
		}

		public int m_Resolution;
		public Appearance m_Appearance;
	}
}
