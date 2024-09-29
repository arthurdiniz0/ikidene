using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class Find : Action
	{
		public SharedGameObject targetGameObject;
		public SharedString transformName;
		public SharedTransform storeValue;
	}
}
