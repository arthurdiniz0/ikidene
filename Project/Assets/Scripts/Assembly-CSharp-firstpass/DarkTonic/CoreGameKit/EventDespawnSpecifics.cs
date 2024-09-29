using System;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class EventDespawnSpecifics
	{
		public bool eventEnabled;
		public bool useLayerFilter;
		public bool useTagFilter;
		public List<string> matchingTags;
		public List<int> matchingLayers;
	}
}
