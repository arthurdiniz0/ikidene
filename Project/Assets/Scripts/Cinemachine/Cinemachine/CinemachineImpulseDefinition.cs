using System;

namespace Cinemachine
{
	[Serializable]
	public class CinemachineImpulseDefinition
	{
		public enum RepeatMode
		{
			Stretch = 0,
			Loop = 1,
		}

		public int m_ImpulseChannel;
		public SignalSourceAsset m_RawSignal;
		public float m_AmplitudeGain;
		public float m_FrequencyGain;
		public RepeatMode m_RepeatMode;
		public bool m_Randomize;
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope;
		public float m_ImpactRadius;
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;
		public float m_DissipationDistance;
	}
}
