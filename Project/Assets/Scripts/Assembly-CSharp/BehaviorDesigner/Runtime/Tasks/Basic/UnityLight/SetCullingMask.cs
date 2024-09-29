using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityLight
{
	public class SetCullingMask : Action
	{
		public SharedGameObject targetGameObject;
		public LayerMask cullingMask;
	}
}
