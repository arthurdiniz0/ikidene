using System;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WorldVariableRange
	{
		public WorldVariableRange(string statName, WorldVariableTracker.VariableType vType)
		{
		}

		public int _modValueIntMin;
		public int _modValueIntMax;
		public float _modValueFloatMin;
		public float _modValueFloatMax;
		public string _statName;
		public WorldVariableTracker.VariableType _varTypeToUse;
	}
}
