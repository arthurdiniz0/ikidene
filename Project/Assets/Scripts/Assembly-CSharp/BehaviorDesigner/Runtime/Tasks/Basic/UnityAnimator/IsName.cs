using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class IsName : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedInt index;
		public SharedString name;
	}
}
