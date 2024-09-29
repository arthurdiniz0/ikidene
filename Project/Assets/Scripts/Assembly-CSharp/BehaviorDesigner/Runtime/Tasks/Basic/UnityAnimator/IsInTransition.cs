using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class IsInTransition : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedInt index;
	}
}
