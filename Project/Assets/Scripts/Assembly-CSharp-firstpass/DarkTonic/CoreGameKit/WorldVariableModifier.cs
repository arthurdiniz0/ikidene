using System;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WorldVariableModifier
	{
		public WorldVariableModifier(string statName, WorldVariableTracker.VariableType vType)
		{
		}

		public string _statName;
		public KillerInt _modValueIntAmt;
		public KillerFloat _modValueFloatAmt;
		public WorldVariableTracker.VariableType _varTypeToUse;
	}
}
