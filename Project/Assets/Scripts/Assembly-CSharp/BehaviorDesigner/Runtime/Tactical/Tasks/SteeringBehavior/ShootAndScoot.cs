using BehaviorDesigner.Runtime;

namespace BehaviorDesigner.Runtime.Tactical.Tasks.SteeringBehavior
{
	public class ShootAndScoot : SteeringBehaviorTacticalGroup
	{
		public SharedInt agentsPerRow;
		public SharedVector2 separation;
		public SharedFloat timeStationary;
		public SharedFloat minMoveAngle;
		public SharedFloat maxMoveAngle;
		public SharedFloat minAttackRadius;
		public SharedFloat maxAttackRadius;
	}
}
