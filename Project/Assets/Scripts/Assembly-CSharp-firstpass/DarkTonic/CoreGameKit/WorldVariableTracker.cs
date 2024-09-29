using System;
using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	[Serializable]
	public class WorldVariableTracker : MonoBehaviour
	{
		public enum VariableType
		{
			_integer = 0,
			_float = 1,
		}

		public Transform statPrefab;
		public string newVariableName;
		public bool showNewVarSection;
		public VariableType newVarType;
		public bool worldVariablesExpanded;
		public bool showIntVars;
		public bool showFloatVars;
		public int frames;
	}
}
