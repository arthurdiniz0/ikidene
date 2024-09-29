using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class MarchingFire : SteeringBehaviorTacticalGroup
	{
		public SharedInt agentsPerRow;
		public SharedVector2 separation;
		public SharedFloat attackDistance;
	}
}
