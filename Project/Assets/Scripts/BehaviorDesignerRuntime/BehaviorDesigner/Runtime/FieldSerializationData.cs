using System;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	[Serializable]
	public class FieldSerializationData
	{
		[SerializeField]
		public List<string> typeName;
		[SerializeField]
		public List<int> fieldNameHash;
		[SerializeField]
		public List<int> startIndex;
		[SerializeField]
		public List<int> dataPosition;
		[SerializeField]
		public List<Object> unityObjects;
		[SerializeField]
		public List<byte> byteData;
		public byte[] byteDataArray;
	}
}
