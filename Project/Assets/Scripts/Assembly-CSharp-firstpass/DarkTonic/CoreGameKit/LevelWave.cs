using System;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class LevelWave
	{
		public LevelSettings.WaveType waveType;
		public LevelSettings.SkipWaveMode skipWaveType;
		public WorldVariableCollection skipWavePassCriteria;
		public bool pauseGlobalWavesWhenCompleted;
		public string waveName;
		public string waveClass;
		public LevelWaveMusicSettings musicSettings;
		public int WaveDuration;
		public bool endEarlyIfAllDestroyed;
		public bool waveBeatBonusesEnabled;
		public bool useCompletionEvents;
		public LevelSettings.WaveSpawnerUseMode spawnerUseMode;
		public int spawnersToUseMin;
		public int spawnersToUseMax;
		public bool isDummyWave;
		public List<CGKCustomEventToFire> completionCustomEvents;
		public WorldVariableCollection waveDefeatVariableModifiers;
		public bool isExpanded;
		public int sequencedWaveNumber;
		public int randomWaveNumber;
	}
}
