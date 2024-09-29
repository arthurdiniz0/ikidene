using System;
using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class LevelWaveMusicSettings
	{
		public LevelSettings.WaveMusicMode WaveMusicMode;
		public AudioClip WaveMusic;
		public float WaveMusicVolume;
		public float FadeTime;
	}
}
