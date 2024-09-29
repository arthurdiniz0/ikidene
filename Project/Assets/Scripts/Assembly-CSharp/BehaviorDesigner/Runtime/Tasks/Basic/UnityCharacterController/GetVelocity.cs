using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityCharacterController
{
	public class GetVelocity : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 storeValue;
	}
}
