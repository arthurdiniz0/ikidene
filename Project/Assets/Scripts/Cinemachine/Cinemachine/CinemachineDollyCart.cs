using UnityEngine;

namespace Cinemachine
{
	public class CinemachineDollyCart : MonoBehaviour
	{
		public enum UpdateMethod
		{
			Update = 0,
			FixedUpdate = 1,
		}

		public CinemachinePathBase m_Path;
		public UpdateMethod m_UpdateMethod;
		public CinemachinePathBase.PositionUnits m_PositionUnits;
		public float m_Speed;
		public float m_Position;
	}
}
