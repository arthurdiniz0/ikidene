using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class MoveTowards : Action
	{
		public SharedFloat speed;
		public SharedFloat arriveDistance;
		public SharedBool lookAtTarget;
		public SharedFloat maxLookAtRotationDelta;
		public SharedGameObject target;
		public SharedVector3 targetPosition;
	}
}
