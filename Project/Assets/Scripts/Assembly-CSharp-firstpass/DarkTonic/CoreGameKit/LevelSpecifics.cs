using System;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class LevelSpecifics
	{
		public string levelName;
		public LevelSettings.WaveOrder waveOrder;
		public List<LevelWave> WaveSettings;
		public bool isExpanded;
	}
}
