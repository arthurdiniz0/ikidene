using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetUseGravity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedBool isKinematic;
	}
}
