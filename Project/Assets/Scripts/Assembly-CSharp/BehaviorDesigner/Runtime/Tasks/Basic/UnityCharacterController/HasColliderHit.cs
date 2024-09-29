using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCharacterController
{
	public class HasColliderHit : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedString tag;
		public SharedGameObject collidedGameObject;
	}
}
