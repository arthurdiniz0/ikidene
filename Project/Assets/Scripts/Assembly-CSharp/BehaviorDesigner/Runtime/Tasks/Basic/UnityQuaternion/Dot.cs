using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class Dot : Action
	{
		public SharedQuaternion leftRotation;
		public SharedQuaternion rightRotation;
		public SharedFloat storeResult;
	}
}
