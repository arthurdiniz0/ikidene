using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class IsPlaying : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
	}
}
