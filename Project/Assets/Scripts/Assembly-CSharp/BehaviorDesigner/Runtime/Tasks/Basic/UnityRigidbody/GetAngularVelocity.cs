using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityRigidbody
{
	public class GetAngularVelocity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 storeValue;
	}
}
