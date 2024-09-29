using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityTransform
{
	public class GetAngleToTarget : Action
	{
		public SharedGameObject targetGameObject;
		public SharedGameObject targetObject;
		public SharedVector3 targetPosition;
		public SharedBool ignoreHeight;
		public SharedFloat storeValue;
	}
}
