using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	public class GlobalVariables : ScriptableObject
	{
		[SerializeField]
		private VariableSerializationData mVariableData;
		[SerializeField]
		private string mVersion;
	}
}
