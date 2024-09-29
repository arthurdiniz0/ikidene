using UnityEngine;
using System;

namespace Cinemachine
{
	public class CinemachineVirtualCameraBase : MonoBehaviour
	{
		[Serializable]
		public struct TransitionParams
		{
			public CinemachineVirtualCameraBase.BlendHint m_BlendHint;
			public bool m_InheritPosition;
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive;
		}

		public enum StandbyUpdateMode
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2,
		}

		public enum BlendHint
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3,
		}

		[SerializeField]
		public string[] m_ExcludedPropertiesInInspector;
		[SerializeField]
		public CinemachineCore.Stage[] m_LockStageInInspector;
		[SerializeField]
		private int m_StreamingVersion;
		public int m_Priority;
		public StandbyUpdateMode m_StandbyUpdate;
	}
}
