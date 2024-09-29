using System;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class KillerVariable
	{
		public enum ModMode
		{
			Set = 0,
			Add = 1,
			Sub = 2,
			Mult = 3,
		}

		public LevelSettings.VariableSource variableSource;
		public string worldVariableName;
		public ModMode curModMode;
	}
}
