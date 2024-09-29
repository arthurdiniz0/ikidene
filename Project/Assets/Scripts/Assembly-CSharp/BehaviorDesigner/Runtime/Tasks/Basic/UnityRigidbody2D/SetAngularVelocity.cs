using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class SetAngularVelocity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat angularVelocity;
	}
}
