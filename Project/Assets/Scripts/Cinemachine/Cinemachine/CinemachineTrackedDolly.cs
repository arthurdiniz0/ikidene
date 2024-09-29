using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineTrackedDolly : CinemachineComponentBase
	{
		[Serializable]
		public struct AutoDolly
		{
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) : this()
			{
			}

			public bool m_Enabled;
			public float m_PositionOffset;
			public int m_SearchRadius;
			public int m_SearchResolution;
		}

		public enum CameraUpMode
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4,
		}

		public CinemachinePathBase m_Path;
		public float m_PathPosition;
		public CinemachinePathBase.PositionUnits m_PositionUnits;
		public Vector3 m_PathOffset;
		public float m_XDamping;
		public float m_YDamping;
		public float m_ZDamping;
		public CameraUpMode m_CameraUp;
		public float m_PitchDamping;
		public float m_YawDamping;
		public float m_RollDamping;
		public AutoDolly m_AutoDolly;
	}
}
