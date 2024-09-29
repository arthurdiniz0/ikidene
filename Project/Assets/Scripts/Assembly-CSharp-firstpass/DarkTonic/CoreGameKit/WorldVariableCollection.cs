using System;
using System.Collections.Generic;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WorldVariableCollection
	{
		public string scenarioName;
		public List<WorldVariableModifier> statMods;
	}
}
