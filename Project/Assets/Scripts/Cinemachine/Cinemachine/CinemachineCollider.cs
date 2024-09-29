using UnityEngine;

namespace Cinemachine
{
	public class CinemachineCollider : CinemachineExtension
	{
		public enum ResolutionStrategy
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2,
		}

		public LayerMask m_CollideAgainst;
		public string m_IgnoreTag;
		public LayerMask m_TransparentLayers;
		public float m_MinimumDistanceFromTarget;
		public bool m_AvoidObstacles;
		public float m_DistanceLimit;
		public float m_MinimumOcclusionTime;
		public float m_CameraRadius;
		public ResolutionStrategy m_Strategy;
		public int m_MaximumEffort;
		public float m_SmoothingTime;
		public float m_Damping;
		public float m_DampingWhenOccluded;
		public float m_OptimalTargetDistance;
	}
}
