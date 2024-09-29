using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class SetVelocity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector2 velocity;
	}
}
