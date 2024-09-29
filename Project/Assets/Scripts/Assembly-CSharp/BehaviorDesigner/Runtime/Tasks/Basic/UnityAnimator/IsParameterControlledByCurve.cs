using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityAnimator
{
	public class IsParameterControlledByCurve : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedString paramaterName;
	}
}
