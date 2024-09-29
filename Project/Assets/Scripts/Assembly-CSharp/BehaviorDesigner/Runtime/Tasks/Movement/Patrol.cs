using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Patrol : NavMeshMovement
	{
		public SharedBool randomPatrol;
		public SharedFloat waypointPauseDuration;
		public SharedGameObjectList waypoints;
	}
}
