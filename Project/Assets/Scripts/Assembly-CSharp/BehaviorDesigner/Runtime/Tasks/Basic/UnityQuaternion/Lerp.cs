using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityQuaternion
{
	public class Lerp : Action
	{
		public SharedQuaternion fromQuaternion;
		public SharedQuaternion toQuaternion;
		public SharedFloat amount;
		public SharedQuaternion storeResult;
	}
}
