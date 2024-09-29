using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class CrossFade : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString stateName;
		public SharedFloat transitionDuration;
		public int layer;
		public float normalizedTime;
	}
}
