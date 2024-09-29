using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineSmoothPath : CinemachinePathBase
	{
		[Serializable]
		public struct Waypoint
		{
			public Vector3 position;
			public float roll;
		}

		public bool m_Looped;
		public Waypoint[] m_Waypoints;
	}
}
