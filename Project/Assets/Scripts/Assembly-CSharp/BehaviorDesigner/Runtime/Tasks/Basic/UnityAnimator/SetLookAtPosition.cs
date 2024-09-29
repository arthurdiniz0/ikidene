using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class SetLookAtPosition : Action
	{
		public SharedGameObject targetGameObject;
		public SharedVector3 position;
	}
}
