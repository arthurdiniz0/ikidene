using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetPosition : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 position;
	}
}
