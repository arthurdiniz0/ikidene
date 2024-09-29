using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class LookRotation : Action
	{
		public SharedVector3 forwardVector;
		public SharedVector3 secondVector3;
		public SharedQuaternion storeResult;
	}
}
