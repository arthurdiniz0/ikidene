using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetShadows : Action
	{
		public SharedGameObject targetGameObject;
		public LightShadows shadows;
	}
}
