using System;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	[Serializable]
	public class BehaviorSource
	{
		public string behaviorName;
		public string behaviorDescription;
		[SerializeField]
		private TaskSerializationData mTaskData;
	}
}
