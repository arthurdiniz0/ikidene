using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class Play : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString stateName;
		public int layer;
		public float normalizedTime;
	}
}
