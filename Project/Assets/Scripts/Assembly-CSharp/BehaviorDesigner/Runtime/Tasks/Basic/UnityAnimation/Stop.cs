using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimation
{
	public class Stop : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString animationName;
	}
}
