using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class Charge : SteeringBehaviorTacticalGroup
	{
		public SharedInt agentsPerRow;
		public SharedVector2 separation;
		public SharedFloat attackDistance;
	}
}
