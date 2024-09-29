using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	public class WavePrefabPool : MonoBehaviour
	{
		public enum PoolDispersalMode
		{
			Randomized = 0,
			OriginalPoolOrder = 1,
		}

		public bool isExpanded;
		public bool exhaustiveList;
		public PoolDispersalMode dispersalMode;
		public WavePrefabPoolListener listener;
		public List<WavePrefabPoolItem> poolItems;
	}
}
