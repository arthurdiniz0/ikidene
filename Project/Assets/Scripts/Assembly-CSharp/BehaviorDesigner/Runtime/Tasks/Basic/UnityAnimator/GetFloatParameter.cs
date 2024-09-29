using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class GetFloatParameter : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString paramaterName;
		public SharedFloat storeValue;
	}
}
