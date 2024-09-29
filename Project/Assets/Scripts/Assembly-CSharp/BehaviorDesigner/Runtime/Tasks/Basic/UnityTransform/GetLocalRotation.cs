using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class GetLocalRotation : Action
	{
		public SharedGameObject targetGameObject;
		public SharedQuaternion storeValue;
	}
}
