using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	public class LevelSettings : MonoBehaviour
	{
		public enum SpawnerType
		{
			Green = 0,
			Red = 1,
		}

		public enum WaveMusicMode
		{
			KeepPreviousMusic = 0,
			PlayNew = 1,
			Silence = 2,
		}

		public enum WaveRestartBehavior
		{
			LeaveSpawned = 0,
			DestroySpawned = 1,
			DespawnSpawned = 2,
		}

		public enum VariableSource
		{
			Variable = 0,
			Self = 1,
		}

		public enum WaveOrder
		{
			SpecifiedOrder = 0,
			RandomOrder = 1,
		}

		public enum WaveType
		{
			Timed = 0,
			Elimination = 1,
		}

		public enum SkipWaveMode
		{
			None = 0,
			Always = 1,
			IfWorldVariableValueAbove = 2,
			IfWorldVariableValueBelow = 3,
		}

		public enum WaveSpawnerUseMode
		{
			AllAbove = 0,
			RandomSubset = 1,
		}

		public enum LevelLoopMode
		{
			Win = 0,
			RepeatAllLevelsFromBeginning = 1,
		}

		public enum EventReceiveMode
		{
			Always = 0,
			WhenDistanceLessThan = 1,
			WhenDistanceMoreThan = 2,
			Never = 3,
		}

		public enum EventReceiveFilter
		{
			All = 0,
			Closest = 1,
			Random = 2,
		}

		public enum ActiveItemMode
		{
			Always = 0,
			Never = 1,
			IfWorldVariableInRange = 2,
			IfWorldVariableOutsideRange = 3,
		}

		public enum SpawnPositionMode
		{
			UseVector3 = 0,
			UseThisObjectPosition = 1,
			UseOtherObjectPosition = 2,
		}

		public enum RotationType
		{
			Identity = 0,
			CustomEuler = 1,
			SpawnerRotation = 2,
		}

		public bool useMusicSettings;
		public bool showLevelSettings;
		public bool showCustomEvents;
		public bool gameStatsExpanded;
		public string newEventName;
		public LevelSettingsListener listener;
		public Transform RedSpawnerTrans;
		public Transform GreenSpawnerTrans;
		public Transform PrefabPoolTrans;
		public string newSpawnerName;
		public bool newPrefabPoolExpanded;
		public string newPrefabPoolName;
		public SpawnerType newSpawnerType;
		public LevelWaveMusicSettings gameOverMusicSettings;
		public bool spawnersExpanded;
		public bool createSpawnerExpanded;
		public bool createPrefabPoolsExpanded;
		public bool killerPoolingExpanded;
		public bool disableSyncroSpawners;
		public bool startFirstWaveImmediately;
		public WaveRestartBehavior waveRestartMode;
		public bool enableWaveWarp;
		public KillerInt startLevelNumber;
		public KillerInt startWaveNumber;
		public bool persistBetweenScenes;
		public bool isLoggingOn;
		public List<LevelSpecifics> LevelTimes;
		public bool useWaves;
		public bool showCustomWaveClasses;
		public List<string> customWaveClasses;
		public LevelLoopMode repeatLevelMode;
		public List<CgkCustomEvent> customEvents;
		public bool initializationSettingsExpanded;
		public List<CGKCustomEventToFire> initializationCustomEvents;
		public int _frames;
	}
}
