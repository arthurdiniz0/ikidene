using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class FromToRotation : Action
	{
		public SharedVector3 fromDirection;
		public SharedVector3 toDirection;
		public SharedQuaternion storeResult;
	}
}
