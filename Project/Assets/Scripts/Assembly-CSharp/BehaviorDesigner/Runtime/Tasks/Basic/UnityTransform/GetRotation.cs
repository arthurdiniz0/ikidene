using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class GetRotation : Action
	{
		public SharedGameObject targetGameObject;
		public SharedQuaternion storeValue;
	}
}
