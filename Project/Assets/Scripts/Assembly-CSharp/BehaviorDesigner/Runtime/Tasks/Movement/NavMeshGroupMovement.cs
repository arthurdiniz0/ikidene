using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tasks.Movement
{
	public class NavMeshGroupMovement : GroupMovement
	{
		public SharedGameObject[] agents;
		public SharedFloat speed;
		public SharedFloat angularSpeed;
	}
}
