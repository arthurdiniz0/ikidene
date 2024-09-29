using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class GetLayerWeight : Action
	{
		public SharedGameObject targetGameObject;
		public SharedInt index;
		public SharedFloat storeValue;
	}
}
