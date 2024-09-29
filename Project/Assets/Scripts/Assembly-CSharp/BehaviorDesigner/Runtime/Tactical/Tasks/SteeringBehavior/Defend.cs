using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class Defend : SteeringBehaviorTacticalGroup
	{
		public SharedGameObject defendObject;
		public SharedFloat radius;
		public SharedFloat defendRadius;
		public SharedFloat maxDistance;
	}
}
