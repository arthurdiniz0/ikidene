using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class SetIntegerParameter : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString paramaterName;
		public SharedInt intValue;
		public bool setOnce;
	}
}
