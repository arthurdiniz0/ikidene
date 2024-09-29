using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks
{
	public class Defend : NavMeshTacticalGroup
	{
		public SharedGameObject defendObject;
		public SharedFloat radius;
		public SharedFloat defendRadius;
		public SharedFloat maxDistance;
	}
}
