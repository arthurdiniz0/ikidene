using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class LeaderFollow : NavMeshGroupMovement
	{
		public SharedFloat neighborDistance;
		public SharedFloat leaderBehindDistance;
		public SharedFloat separationDistance;
		public SharedFloat aheadDistance;
		public SharedGameObject leader;
	}
}
