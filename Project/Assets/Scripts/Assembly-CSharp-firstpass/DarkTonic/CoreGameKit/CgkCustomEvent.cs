using System;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class CgkCustomEvent
	{
		public CgkCustomEvent(string eventName)
		{
		}

		public string EventName;
		public string ProspectiveName;
		public bool IsEditing;
		public bool eventExpanded;
		public LevelSettings.EventReceiveMode eventRcvMode;
		public LevelSettings.EventReceiveFilter eventRcvFilterMode;
		public int filterModeQty;
		public KillerFloat distanceThreshold;
		public int frameLastFired;
	}
}
