using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class NavMeshMovement : Movement
	{
		public SharedFloat speed;
		public SharedFloat angularSpeed;
		public SharedFloat arriveDistance;
		public SharedBool stopOnTaskEnd;
		public SharedBool updateRotation;
	}
}
