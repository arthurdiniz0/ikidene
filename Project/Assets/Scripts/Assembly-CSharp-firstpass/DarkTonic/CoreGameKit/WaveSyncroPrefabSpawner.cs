using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	public class WaveSyncroPrefabSpawner : MonoBehaviour
	{
		public enum SpawnLayerTagMode
		{
			UseSpawnPrefabSettings = 0,
			UseSpawnerSettings = 1,
			Custom = 2,
		}

		public List<WaveSpecifics> waveSpecs;
		public bool isExpanded;
		public LevelSettings.ActiveItemMode activeMode;
		public WorldVariableRangeCollection activeItemCriteria;
		public int randomSortKey;
		public TriggeredSpawner.GameOverBehavior gameOverBehavior;
		public TriggeredSpawner.WavePauseBehavior wavePauseBehavior;
		public WaveSyncroSpawnerListener listener;
		public SpawnLayerTagMode spawnLayerMode;
		public SpawnLayerTagMode spawnTagMode;
		public int spawnCustomLayer;
		public string spawnCustomTag;
	}
}
