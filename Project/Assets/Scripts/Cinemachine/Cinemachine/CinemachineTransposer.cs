using UnityEngine;

namespace Cinemachine
{
	public class CinemachineTransposer : CinemachineComponentBase
	{
		public enum BindingMode
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5,
		}

		public BindingMode m_BindingMode;
		public Vector3 m_FollowOffset;
		public float m_XDamping;
		public float m_YDamping;
		public float m_ZDamping;
		public float m_PitchDamping;
		public float m_YawDamping;
		public float m_RollDamping;
	}
}
