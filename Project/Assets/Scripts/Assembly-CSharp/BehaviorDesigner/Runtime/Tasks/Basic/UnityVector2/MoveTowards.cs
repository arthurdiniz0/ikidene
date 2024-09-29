using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector2
{
	public class MoveTowards : Action
	{
		public SharedVector2 currentPosition;
		public SharedVector2 targetPosition;
		public SharedFloat speed;
		public SharedVector2 storeResult;
	}
}
