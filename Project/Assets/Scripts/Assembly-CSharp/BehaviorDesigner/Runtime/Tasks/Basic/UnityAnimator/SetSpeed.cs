using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class SetSpeed : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat speed;
	}
}
