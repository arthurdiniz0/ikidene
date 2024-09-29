using System;
using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WavePrefabPoolItem
	{
		public Transform prefabToSpawn;
		public string prefabPoolBossCategory;
		public LevelSettings.ActiveItemMode activeMode;
		public WorldVariableRangeCollection activeItemCriteria;
		public KillerInt thisWeight;
		public bool isExpanded;
	}
}
