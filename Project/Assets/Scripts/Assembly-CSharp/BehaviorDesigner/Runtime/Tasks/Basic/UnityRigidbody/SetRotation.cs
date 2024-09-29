using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetRotation : Action
	{
		public SharedGameObject targetGameObject;
		public SharedQuaternion rotation;
	}
}
