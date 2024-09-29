using System;
using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class PoolBossItem
	{
		public Transform prefabTransform;
		public int instancesToPreload;
		public bool isExpanded;
		public bool logMessages;
		public bool allowInstantiateMore;
		public int itemHardLimit;
		public bool allowRecycle;
		public string categoryName;
	}
}
