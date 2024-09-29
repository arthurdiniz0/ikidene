using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class Inverse : Action
	{
		public SharedQuaternion targetQuaternion;
		public SharedQuaternion storeResult;
	}
}
