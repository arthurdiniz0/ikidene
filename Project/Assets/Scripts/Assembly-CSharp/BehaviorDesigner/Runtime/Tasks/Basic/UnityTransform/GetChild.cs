using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class GetChild : Action
	{
		public SharedGameObject targetGameObject;
		public SharedInt index;
		public SharedTransform storeValue;
	}
}
