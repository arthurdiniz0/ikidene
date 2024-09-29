using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class SetParent : Action
	{
		public SharedGameObject targetGameObject;
		public SharedTransform parent;
	}
}
