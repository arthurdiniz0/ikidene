using System;
using UnityEngine;

namespace BehaviorDesigner.Runtime
{
	[Serializable]
	public class ExternalBehavior : ScriptableObject
	{
		[SerializeField]
		private BehaviorSource mBehaviorSource;
	}
}
