using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCharacterController
{
	public class SetRadius : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat radius;
	}
}
