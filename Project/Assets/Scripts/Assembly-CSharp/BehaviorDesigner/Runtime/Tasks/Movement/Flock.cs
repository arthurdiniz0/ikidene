using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Flock : NavMeshGroupMovement
	{
		public SharedFloat neighborDistance;
		public SharedFloat lookAheadDistance;
		public SharedFloat alignmentWeight;
		public SharedFloat cohesionWeight;
		public SharedFloat separationWeight;
	}
}
