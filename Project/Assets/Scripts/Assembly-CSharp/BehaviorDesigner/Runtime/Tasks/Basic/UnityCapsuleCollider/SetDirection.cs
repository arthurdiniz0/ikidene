using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCapsuleCollider
{
	public class SetDirection : Action
	{
		public SharedGameObject targetGameObject;
		public SharedInt direction;
	}
}
