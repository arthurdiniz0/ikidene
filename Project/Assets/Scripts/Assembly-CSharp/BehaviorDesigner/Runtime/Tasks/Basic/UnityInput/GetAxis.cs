using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityInput
{
	public class GetAxis : Action
	{
		public SharedString axisName;
		public SharedFloat multiplier;
		public SharedFloat storeResult;
	}
}
