using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class Leapfrog : SteeringBehaviorTacticalGroup
	{
		public SharedFloat separation;
		public SharedFloat groupSeparation;
		public SharedFloat leapDistance;
	}
}
