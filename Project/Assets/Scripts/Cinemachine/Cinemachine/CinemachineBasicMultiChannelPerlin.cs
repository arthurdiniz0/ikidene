using UnityEngine;

namespace Cinemachine
{
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
	{
		public NoiseSettings m_NoiseProfile;
		public float m_AmplitudeGain;
		public float m_FrequencyGain;
		[SerializeField]
		private Vector3 mNoiseOffsets;
	}
}
