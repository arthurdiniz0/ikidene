using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Seek : NavMeshMovement
	{
		public SharedGameObject target;
		public SharedVector3 targetPosition;
	}
}
