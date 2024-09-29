using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class RotateTowards : Action
	{
		public SharedQuaternion fromQuaternion;
		public SharedQuaternion toQuaternion;
		public SharedFloat maxDeltaDegrees;
		public SharedQuaternion storeResult;
	}
}
