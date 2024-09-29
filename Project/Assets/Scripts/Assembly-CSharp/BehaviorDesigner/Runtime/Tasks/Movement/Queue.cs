using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Queue : NavMeshGroupMovement
	{
		public SharedFloat neighborDistance;
		public SharedFloat separationDistance;
		public SharedFloat maxQueueAheadDistance;
		public SharedFloat maxQueueRadius;
		public SharedFloat slowDownSpeed;
		public SharedGameObject target;
	}
}
