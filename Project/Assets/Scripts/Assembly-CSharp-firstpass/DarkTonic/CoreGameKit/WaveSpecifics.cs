using System;
using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WaveSpecifics
	{
		public enum SpawnOrigin
		{
			Specific = 0,
			PrefabPool = 1,
		}

		public enum RepeatWaveMode
		{
			Endless = 0,
			NumberOfRepetitions = 1,
			UntilWorldVariableAbove = 2,
			UntilWorldVariableBelow = 3,
		}

		public enum TimedRepeatWaveMode
		{
			EliminationStyle = 0,
			StrictTimeStyle = 1,
		}

		public enum PositionMode
		{
			SpawnerPosition = 0,
			CustomPosition = 1,
			OtherObjectPosition = 2,
		}

		public enum RotationMode
		{
			UsePrefabRotation = 0,
			UseSpawnerRotation = 1,
			CustomRotation = 2,
			LookAtCustomEventOrigin = 3,
		}

		public enum WaveOffsetChoiceMode
		{
			RandomlyChosen = 0,
			UseInOrder = 1,
		}

		public enum SpawnerRotationMode
		{
			KeepRotation = 0,
			LookAtCustomEventOrigin = 1,
		}

		public bool isExpanded;
		public bool enableWave;
		public bool visualizeWave;
		public int SpawnLevelNumber;
		public int SpawnWaveNumber;
		public KillerInt MinToSpwn;
		public KillerInt MaxToSpwn;
		public KillerFloat WaveDelaySec;
		public KillerFloat TimeToSpawnEntireWave;
		public Transform prefabToSpawn;
		public string prefabToSpawnCategoryName;
		public SpawnOrigin spawnSource;
		public int prefabPoolIndex;
		public string prefabPoolName;
		public bool repeatWaveUntilNew;
		public int waveCompletePercentage;
		public RepeatWaveMode curWaveRepeatMode;
		public TimedRepeatWaveMode curTimedRepeatWaveMode;
		public KillerFloat repeatPauseMinimum;
		public KillerFloat repeatPauseMaximum;
		public KillerInt repeatItemInc;
		public KillerFloat repeatTimeInc;
		public KillerInt repeatItemLmt;
		public KillerFloat repeatTimeLmt;
		public KillerInt repetitionsToDo;
		public WorldVariableCollection repeatPassCriteria;
		public bool waveRepeatBonusesEnabled;
		public WorldVariableCollection waveRepeatVariableModifiers;
		public bool waveRepeatFireEvents;
		public List<CGKCustomEventToFire> waveRepeatCustomEvents;
		public bool positionExpanded;
		public PositionMode positionXmode;
		public PositionMode positionYmode;
		public PositionMode positionZmode;
		public KillerFloat customPosX;
		public KillerFloat customPosY;
		public KillerFloat customPosZ;
		public Transform otherObjectX;
		public Transform otherObjectY;
		public Transform otherObjectZ;
		public RotationMode curRotationMode;
		public Vector3 customRotation;
		public bool enableLimits;
		public KillerFloat doNotSpawnIfMbrCloserThan;
		public KillerFloat doNotSpawnRandomDist;
		public bool enableRandomizations;
		public bool randomXRotation;
		public bool randomYRotation;
		public bool randomZRotation;
		public KillerFloat randomDistX;
		public KillerFloat randomDistY;
		public KillerFloat randomDistZ;
		public KillerFloat randomXRotMin;
		public KillerFloat randomXRotMax;
		public KillerFloat randomYRotMin;
		public KillerFloat randomYRotMax;
		public KillerFloat randomZRotMin;
		public KillerFloat randomZRotMax;
		public bool enableIncrements;
		public bool enableKeepCenter;
		public KillerFloat incrementPositionX;
		public KillerFloat incrementPositionY;
		public KillerFloat incrementPositionZ;
		public KillerFloat incrementRotX;
		public KillerFloat incrementRotY;
		public KillerFloat incrementRotZ;
		public WaveOffsetChoiceMode offsetChoiceMode;
		public List<Vector3> waveOffsetList;
		public bool enablePostSpawnNudge;
		public KillerFloat postSpawnNudgeFwd;
		public KillerFloat postSpawnNudgeRgt;
		public KillerFloat postSpawnNudgeDwn;
	}
}
