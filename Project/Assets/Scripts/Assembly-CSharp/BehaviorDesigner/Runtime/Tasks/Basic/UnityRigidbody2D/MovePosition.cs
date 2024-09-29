using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody2D
{
	public class MovePosition : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector2 position;
	}
}
