using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class GetDeltaRotation : Action
	{
		public SharedGameObject targetGameObject;
		public SharedQuaternion storeValue;
	}
}
