using UnityEngine;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	public class PoolBoss : MonoBehaviour
	{
		public List<PoolBossItem> poolItems;
		public bool logMessages;
		public bool useTextFilter;
		public bool showLegend;
		public string textFilter;
		public bool autoAddMissingPoolItems;
		public string newCategoryName;
		public string addToCategoryName;
		public int _changes;
		public List<PoolBossCategory> _categories;
	}
}
