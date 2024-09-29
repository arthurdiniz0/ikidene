using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Basic.UnityVector3
{
	public class MoveTowards : Action
	{
		public SharedVector3 currentPosition;
		public SharedVector3 targetPosition;
		public SharedFloat speed;
		public SharedVector3 storeResult;
	}
}
