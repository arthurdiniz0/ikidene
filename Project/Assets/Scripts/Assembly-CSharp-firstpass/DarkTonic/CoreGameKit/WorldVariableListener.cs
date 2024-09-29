using UnityEngine;

namespace DarkTonic.CoreGameKit
{
	public class WorldVariableListener : MonoBehaviour
	{
		public string variableName;
		public WorldVariableTracker.VariableType vType;
		public int decimalPlaces;
		public bool useCommaFormatting;
		public int xStart;
	}
}
