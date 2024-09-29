using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class GetRotation : Action
	{
		public SharedGameObject targetGameObject;
		public SharedQuaternion storeValue;
	}
}
