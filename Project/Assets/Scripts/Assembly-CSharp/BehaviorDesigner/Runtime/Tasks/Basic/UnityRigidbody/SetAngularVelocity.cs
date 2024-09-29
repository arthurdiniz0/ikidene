using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class SetAngularVelocity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 angularVelocity;
	}
}
