using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachinePath : CinemachinePathBase
	{
		[Serializable]
		public struct Waypoint
		{
			public Vector3 position;
			public Vector3 tangent;
			public float roll;
		}

		public bool m_Looped;
		public Waypoint[] m_Waypoints;
	}
}
