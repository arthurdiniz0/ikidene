using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class IsChildOf : Conditional
	{
		public SharedGameObject targetGameObject;
		public SharedTransform transformName;
	}
}
