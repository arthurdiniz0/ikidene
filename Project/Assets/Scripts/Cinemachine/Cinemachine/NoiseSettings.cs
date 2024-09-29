using System;

namespace Cinemachine
{
	public class NoiseSettings : SignalSourceAsset
	{
		[Serializable]
		public struct NoiseParams
		{
			public float Frequency;
			public float Amplitude;
			public bool Constant;
		}

		[Serializable]
		public struct TransformNoiseParams
		{
			public NoiseSettings.NoiseParams X;
			public NoiseSettings.NoiseParams Y;
			public NoiseSettings.NoiseParams Z;
		}

		public TransformNoiseParams[] PositionNoise;
		public TransformNoiseParams[] OrientationNoise;
	}
}
