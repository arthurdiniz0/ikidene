using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Flee : NavMeshMovement
	{
		public SharedFloat fleedDistance;
		public SharedFloat lookAheadDistance;
		public SharedGameObject target;
	}
}
