using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class SetLocalRotation : Action
	{
		public SharedGameObject targetGameObject;
		public SharedQuaternion localRotation;
	}
}
