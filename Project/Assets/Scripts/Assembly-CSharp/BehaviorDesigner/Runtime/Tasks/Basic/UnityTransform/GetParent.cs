using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class GetParent : Action
	{
		public SharedGameObject targetGameObject;
		public SharedTransform storeValue;
	}
}
