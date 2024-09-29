using UnityEngine;
using System;

namespace Cinemachine
{
	public class CinemachineTargetGroup : MonoBehaviour
	{
		[Serializable]
		public struct Target
		{
			public Transform target;
			public float weight;
			public float radius;
		}

		public enum PositionMode
		{
			GroupCenter = 0,
			GroupAverage = 1,
		}

		public enum RotationMode
		{
			Manual = 0,
			GroupAverage = 1,
		}

		public enum UpdateMethod
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2,
		}

		public PositionMode m_PositionMode;
		public RotationMode m_RotationMode;
		public UpdateMethod m_UpdateMethod;
		public Target[] m_Targets;
	}
}
