using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class SetWrapMode : Action
	{
		public SharedGameObject targetGameObject;
		public WrapMode wrapMode;
	}
}
