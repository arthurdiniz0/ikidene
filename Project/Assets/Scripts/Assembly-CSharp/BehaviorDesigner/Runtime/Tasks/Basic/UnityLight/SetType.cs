using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetType : Action
	{
		public SharedGameObject targetGameObject;
		public LightType type;
	}
}
