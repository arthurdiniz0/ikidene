using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class WaitForState : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString stateName;
		public SharedInt layer;
	}
}
