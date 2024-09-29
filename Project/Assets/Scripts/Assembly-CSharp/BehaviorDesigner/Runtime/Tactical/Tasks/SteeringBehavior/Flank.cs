using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class Flank : SteeringBehaviorTacticalGroup
	{
		public SharedBool dualFlank;
		public SharedFloat attackDelay;
		public SharedFloat approachDistance;
		public SharedFloat separation;
	}
}
