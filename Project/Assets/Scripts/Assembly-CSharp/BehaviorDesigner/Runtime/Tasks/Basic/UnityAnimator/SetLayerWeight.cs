using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class SetLayerWeight : Action
	{
		public SharedGameObject targetGameObject;
		public SharedInt index;
		public SharedFloat weight;
	}
}
