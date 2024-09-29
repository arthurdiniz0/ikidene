using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetAngularDrag : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat angularDrag;
	}
}
