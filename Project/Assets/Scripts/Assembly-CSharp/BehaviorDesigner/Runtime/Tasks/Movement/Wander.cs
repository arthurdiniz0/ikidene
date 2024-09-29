using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Wander : NavMeshMovement
	{
		public SharedFloat minWanderDistance;
		public SharedFloat maxWanderDistance;
		public SharedFloat wanderRate;
		public SharedFloat minPauseDuration;
		public SharedFloat maxPauseDuration;
		public SharedInt targetRetries;
	}
}
