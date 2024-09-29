using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class GetDeltaPosition : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 storeValue;
	}
}
