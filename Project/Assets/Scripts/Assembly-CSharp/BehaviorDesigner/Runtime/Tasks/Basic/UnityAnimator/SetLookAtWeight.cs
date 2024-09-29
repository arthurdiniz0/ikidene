using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class SetLookAtWeight : Action
	{
		public SharedGameObject targetGameObject;
		public SharedFloat weight;
		public float bodyWeight;
		public float headWeight;
		public float eyesWeight;
		public float clampWeight;
	}
}
