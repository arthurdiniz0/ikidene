using System;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class TriggeredWaveMetaData
	{
		public WavePrefabPool wavePool;
		public List<Transform> spawnedWaveMembers;
		public int currentWaveSize;
		public float waveStartTime;
		public bool waveFinishedSpawning;
		public int countSpawned;
		public float singleSpawnTime;
		public float lastSpawnTime;
		public TriggeredWaveSpecifics waveSpec;
		public int waveRepetitionNumber;
		public float previousWaveEndTime;
	}
}
