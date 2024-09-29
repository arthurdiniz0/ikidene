using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class Blend : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
		public float targetWeight;
		public float fadeLength;
	}
}
