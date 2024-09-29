using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class Euler : Action
	{
		public SharedVector3 eulerVector;
		public SharedQuaternion storeResult;
	}
}
