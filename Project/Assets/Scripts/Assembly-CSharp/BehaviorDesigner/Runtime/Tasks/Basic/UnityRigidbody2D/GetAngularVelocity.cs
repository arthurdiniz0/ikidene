using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class GetAngularVelocity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat storeValue;
	}
}
