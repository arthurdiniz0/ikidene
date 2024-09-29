using System;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	[Serializable]
	public class TaskSerializationData
	{
		[SerializeField]
		public List<string> types;
		[SerializeField]
		public List<int> parentIndex;
		[SerializeField]
		public List<int> startIndex;
		[SerializeField]
		public List<int> variableStartIndex;
		[SerializeField]
		public string JSONSerialization;
		[SerializeField]
		public FieldSerializationData fieldSerializationData;
		[SerializeField]
		public string Version;
	}
}
