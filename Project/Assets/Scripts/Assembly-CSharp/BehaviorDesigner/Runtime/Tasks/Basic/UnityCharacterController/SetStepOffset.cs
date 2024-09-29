using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCharacterController
{
	public class SetStepOffset : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat stepOffset;
	}
}
