using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class Angle : Action
	{
		public SharedQuaternion firstRotation;
		public SharedQuaternion secondRotation;
		public SharedFloat storeResult;
	}
}
