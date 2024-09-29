using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class Follow : NavMeshMovement
	{
		public SharedGameObject target;
		public SharedFloat moveDistance;
	}
}
