using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class Hold : SteeringBehaviorTacticalGroup
	{
		public SharedGameObject defendObject;
		public SharedFloat radius;
		public SharedFloat defendRadius;
	}
}
