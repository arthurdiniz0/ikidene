using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCharacterController
{
	public class SetSlopeLimit : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat slopeLimit;
	}
}
