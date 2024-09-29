using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityInput
{
	public class GetMouseButton : Action
	{
		public SharedInt buttonIndex;
		public SharedBool storeResult;
	}
}
