using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCharacterController
{
	public class SetHeight : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat height;
	}
}
