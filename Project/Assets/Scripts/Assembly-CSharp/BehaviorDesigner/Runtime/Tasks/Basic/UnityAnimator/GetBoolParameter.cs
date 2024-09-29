using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class GetBoolParameter : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString paramaterName;
		public SharedBool storeValue;
	}
}
